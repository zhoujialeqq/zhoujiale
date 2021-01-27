using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 pos = Vector3.zero;
    public Animator anim;
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
            transform.LookAt(transform.position + pos);
            transform.Translate(Vector3.forward * Time.deltaTime * ChooseRole.mess.move);
            anim.SetFloat("Run", 1f);
        }
        else
        {
            anim.SetFloat("Run", 0f);
        }

        Camera.main.transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
        Camera.main.transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y"));

        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void LateUpdate()
    {
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, transform.position + new Vector3(0, 2f, 0), Time.deltaTime * ChooseRole.mess.move);
    }
}
