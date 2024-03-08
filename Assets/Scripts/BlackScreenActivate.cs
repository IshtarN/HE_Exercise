using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreenActivate : MonoBehaviour
{
    public bool isActive;
    public GameObject blackScreen;
    // Start is called before the first frame update
    void Start()
    {
        blackScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
