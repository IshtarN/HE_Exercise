using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // end application
    public void clickedNo()
    {
        Application.Quit();
    }
}
