using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jole : MonoBehaviour
{
    public Button p1, p2, p3, begin;
    public Text  mm;
    shuju role = new shuju ();
    // Start is called before the first frame update
    void Start()
    {
        mm.text = "Player1\n\n血量500\n移动速度系数3\n占点进度系数1";
        role.name = "Player1";
        role.blood = 500;
        role.move = 3;
        role.add = 1;
        p1.onClick.AddListener(() =>
        {
            mm.text = "Player1\n\n血量500\n移动速度系数3\n占点进度系数1";
            role.name = "Player1";
            role.blood = 500;
            role.move = 3;
            role.add = 1;
        });
        p2.onClick.AddListener(() =>
        {
            mm.text = "Player2\n\n血量300\n移动速度系数5\n占点进度系数3";
            role.name = "Player2";
            role.blood = 300;
            role.move = 5;
            role.add = 13;
        });
        p3.onClick.AddListener(() =>
        {
            mm.text = "Player3\n\n血量100\n移动速度系数10\n占点进度系数2";
            role.name = "Player3";
            role.blood = 100;
            role.move = 10;
            role.add = 2;
        });
        begin.onClick.AddListener(() =>
        {
            ChooseRole.name = role.name;
            ChooseRole.mess = role;
            SceneManager.LoadScene("MainScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
