using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject popup;
    public GameObject button;
    public GameObject switchB;
    int buttonCounter;
    int switchCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TriggerPopUp();
    }

    /*
     1. appear at total 10 between counters
     2. if YES is clicked (need to getcomp/findcomp for button), reset counters & dial position (rotation at all 0s, spinspeed 0, canRotate false)
     3. if NO is clicked end program ( Application.Quit(); )
     */


    public void TriggerPopUp()
    {
        buttonCounter = button.GetComponent<ButtonBehavior>().counter;
        switchCounter = switchB.GetComponent<SwitchBehavior>().counter;

        if ( (buttonCounter + switchCounter) >= 10){
            popup.SetActive(true);
        }
    }  

}
