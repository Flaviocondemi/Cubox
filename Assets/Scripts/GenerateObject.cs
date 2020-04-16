using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{

    public GameObject obj;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obj, pos);
    }

}
