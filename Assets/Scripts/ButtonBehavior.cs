using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public GameObject dial;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void buttonClick()
    {
        counter++;

        // when clicked, switches what the current canRotate behavior is
        if (dial.GetComponent<DialBehavior>().canRotate == true)
        {
            dial.GetComponent<DialBehavior>().canRotate = false;
        }
        else
        {
            dial.GetComponent<DialBehavior>().canRotate = true;
        }
    }
}
