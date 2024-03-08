using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;


public class YesButtonBehavior : MonoBehaviour
{

    public GameObject popup;
    public GameObject dial;
    public GameObject button;
    public GameObject switchB;
    public Sprite switchDown;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void clickedYes()
    {
        // reset counters to 0
        button.GetComponent<ButtonBehavior>().counter = 0;
        switchB.GetComponent<SwitchBehavior>().counter = 0;

        // reset switch sprite
        switchB.GetComponent<Image>().sprite = switchDown;

        // reset dial position & bools (rotation at all 0s, canRotate false, spinClockwise true)
        dial.transform.rotation = Quaternion.Euler(0, 0, 0);
        dial.GetComponent<DialBehavior>().canRotate = false;
        dial.GetComponent<DialBehavior>().spinClockwise = true;
        
        // set popup to inactive
        popup.SetActive(false);
    }
}
