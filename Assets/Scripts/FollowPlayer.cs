using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject playerObject;
    private Vector3 offset = new Vector3(0, 0, -3);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = playerObject.transform.position + offset;
    }

}
