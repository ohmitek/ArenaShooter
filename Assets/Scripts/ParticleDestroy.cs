using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return StartCoroutine(DestroyAfterTime(3.0f));

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
