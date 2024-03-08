using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class SwitchBehavior : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
        //InvokeSwitch();
        if (isFlippedUp)
        {
            // coroutine used to allow for irl pausing
            StartCoroutine(WaitToReset(2));
        } else
        {
            // reset to prevent delays in future switch invocations
            StopAllCoroutines();
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        // save mouse down pos
        firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // save mouse release pos
        secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        InvokeSwitch();
    }

    public void InvokeSwitch()
    {
        // create vector from the two points
        currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

        // normalize vector
        currentSwipe.Normalize();

        // confirm that vector was an upward swipe
        if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
        {
            switchButton.GetComponent<Image>().sprite = switchUp;
            isFlippedUp = true;
            counter++;
            ChangeDialDirection();
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

    IEnumerator WaitToReset(int n)
    {
        yield return new WaitForSeconds(n);
        ResetSwitch();
    }

    // resets switch back to down position
    public void ResetSwitch()
    {
        isFlippedUp = false;
        switchButton.GetComponent<Image>().sprite = switchDown;
    }
}
