using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doudou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-4, 4), 0.25f, Random.Range(-4, 4));
            DD dia = Instantiate(Resources.Load<DD>("chi/Dia"), pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
