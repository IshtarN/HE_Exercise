using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonBehavior : MonoBehaviour
{

    public GameObject BlackScreen;

    // Start is called before the first frame update
    void Start()
    {
        BlackScreen.SetActive(false);
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
            CutToBlack(); // couldn't find cleaner way of doing this within browser
        #elif (UNITY_STANDALONE)
            Application.Quit();
        #endif
    }

    void CutToBlack()
    {
        BlackScreen.SetActive(true);
    }
}
