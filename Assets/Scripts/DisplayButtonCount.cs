using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayButtonCount : MonoBehaviour
{

    public GameObject button;
    public GameObject counterText;
    int counter;



    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter = button.GetComponent<ButtonBehavior>().counter;
        //Debug.Log(counter);
        counterText.GetComponent<TextMeshProUGUI>().text = counter.ToString();
    }
}
