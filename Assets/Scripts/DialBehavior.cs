using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialBehavior : MonoBehaviour
{
    public GameObject dial;
    float spinSpeed = 300f;
    Vector3 rotationDirection;
    public bool canRotate = false;
    public bool spinClockwise = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SpinDial();
    }

    public void SpinDial()
    {
        // reverses the spin direction
        if (spinClockwise)
        {
            rotationDirection = Vector3.back;
        } else
        {
            rotationDirection = Vector3.forward;
        }
        
        if (canRotate)
        {
            dial.transform.Rotate(rotationDirection * spinSpeed * Time.deltaTime);
        }
    }
}
