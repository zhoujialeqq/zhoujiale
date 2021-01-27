using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qiu : MonoBehaviour
{
    Vector3 pos = Vector3.zero;
    Vector3 position = Vector3.zero + new Vector3(0, 0.5f, 0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h != 0 || v != 0)
        {
            pos = new Vector3(h, 0, v);
            position = transform.position;
            transform.LookAt(transform.position + pos);
            transform.Translate(Vector3.forward * Time.deltaTime * 3);
        }
        else
        {
            transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dia")
        {
            Destroy(collision.gameObject);
        }
    }

    private void LateUpdate()
    {
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position,
            new Vector3(position.x, Camera.main.transform.position.y, position.z), Time.deltaTime * 3);
    }
}
