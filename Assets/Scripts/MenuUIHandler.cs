using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

   /* public void EditName()
    {
        MenuUIHandler.Instance.playername = inputField.text; ;
        inputField.text = "";
        GameObject.Find("Player Name").GetComponent<Text>().text = "Welcome" + MenuUIHandler.Instance.p;layerName; ;
    }*/

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    
}
