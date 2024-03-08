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
        // start with popup deactivated
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TriggerPopUp();
    }

    public void TriggerPopUp()
    {
        buttonCounter = button.GetComponent<ButtonBehavior>().counter;
        switchCounter = switchB.GetComponent<SwitchBehavior>().counter;

        // when total between counters is 10, set popup to active
        if ((buttonCounter + switchCounter) >= 10){
            popup.SetActive(true);
        }
    }  

}
