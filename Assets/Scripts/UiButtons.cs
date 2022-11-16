using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiButtons : MonoBehaviour
{
    public Button retryBu;
    // Start is called before the first frame update
    void Start()
    {
        //Button retryButton = retryButton.onClick(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        retryBu.onClick.AddListener(doSomething);
        
    }

    private void doSomething()
    {
        Loader.Load(Loader.Scene.MainScene);
    }

}
