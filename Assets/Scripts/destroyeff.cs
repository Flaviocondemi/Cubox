using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyeff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyEffect());
    }


    IEnumerator destroyEffect()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}

