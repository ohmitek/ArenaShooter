using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return StartCoroutine(DestroyAfterTime(2.0f));
        print("Done " + Time.time);
    }

    IEnumerator DestroyAfterTime(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
