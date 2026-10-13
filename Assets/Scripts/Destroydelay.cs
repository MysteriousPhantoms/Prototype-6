using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroydelay : MonoBehaviour
{
    public float delay;


    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeySpace)
        {
            Destroy(gameObject,delay);
        }
    }
}
