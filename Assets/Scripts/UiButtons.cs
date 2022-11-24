using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiButtons : MonoBehaviour
{
    public Button retryBu;
    public Button quitBu;


    // Update is called once per frame
    void Update()
    {
        retryBu.onClick.AddListener(doSomething);
        quitBu.onClick.AddListener(quitGame);

    }

    private void quitGame()
    {
        Application.Quit();
    }
    private void doSomething()
    {
        Loader.Load(Loader.Scene.MainScene);
    }

}
