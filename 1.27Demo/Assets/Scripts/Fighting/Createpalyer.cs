using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createpalyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject boss = Instantiate(Resources.Load<GameObject>("Player/Boss"), new Vector3(15, 0, 15), Quaternion.identity);
        Player player = Instantiate(Resources.Load<Player>("Player/" + ChooseRole.name), new Vector3(0, 0, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
