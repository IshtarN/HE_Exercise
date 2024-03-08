using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonBehavior : MonoBehaviour
{

    public GameObject blackScreen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // end application based on where game is being played
    public void clickedNo()
    {
        // in Unity editor, WebGL, PC
        #if (UNITY_EDITOR)
            UnityEditor.EditorApplication.isPlaying = false;
        #elif (UNITY_WEBGL)
            CutToBlack();
        #elif (UNITY_STANDALONE)
            Application.Quit();
        #endif
    }

    void CutToBlack()
    {
        blackScreen.SetActive(true); // cleanest way to do this within browser
    }
}
