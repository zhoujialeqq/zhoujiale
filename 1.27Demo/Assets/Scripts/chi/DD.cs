using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD : MonoBehaviour
{
    float angle = 60;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject)
        {
            transform.Rotate(Vector3.up, angle);
        }
    }
}
