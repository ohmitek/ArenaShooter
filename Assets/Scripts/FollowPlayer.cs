using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject playerObject;
    private Vector3 offset = new Vector3(0, 0, -3);

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }

    private void LateUpdate()
    {
        transform.position = playerObject.transform.position + offset;

        //if (Input.GetKey(KeyCode.Escape))
        //{
        //
        //    
        //    Application.Quit();
        //}
    }

}
