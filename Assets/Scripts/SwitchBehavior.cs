using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class SwitchBehavior : MonoBehaviour
{

    bool isFlippedUp = false;
    public int counter = 0;

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    public GameObject dial;
    public GameObject switchButton;
    public Sprite switchDown;
    public Sprite switchUp;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        InvokeSwitch();
        if(isFlippedUp)
        {
            StartCoroutine(waitToReset(2));
        } else
        {
            StopAllCoroutines();
        }
    }

    public void InvokeSwitch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // save mouse down pos
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            // save mouse release pos
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            // normalize vector
            currentSwipe.Normalize();

            // confirm that vector was an upward swipe
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                switchButton.GetComponent<Image>().sprite = switchUp;
                Debug.Log(switchButton.GetComponent<Image>().sprite);
                isFlippedUp = true;
                counter++;
                ChangeDialDirection();
            }
            
        }
    }

    void ChangeDialDirection()
    {
        if (dial.GetComponent<DialBehavior>().spinClockwise == true)
        {
            dial.GetComponent<DialBehavior>().spinClockwise = false;
        }
        else
        {
            dial.GetComponent<DialBehavior>().spinClockwise = true;
        }
    }

    IEnumerator waitToReset(int n)
    {
        yield return new WaitForSeconds(n);
        ResetSwitch();
    }

    public void ResetSwitch()
    {
        isFlippedUp = false;
        switchButton.GetComponent<Image>().sprite = switchDown;
    }

    


}
