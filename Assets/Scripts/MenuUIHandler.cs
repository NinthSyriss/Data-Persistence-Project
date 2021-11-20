using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.IO;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField playerName;


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
        Debug.Log("Player Name is:" + playerName.text);
        MainManager.playerNameStr = playerName.text;
        SceneManager.LoadScene(1);

    }

  

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    
}
