using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suanfa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Init("dfd,gfb,sere.");
    }
    string Init(string str)
    {
        string brr = str;
        string newstr = string.Empty;
        while (str.Contains(",") || str.Contains("."))
        {
            int d = str.IndexOf(',');
            int j = str.IndexOf('.');
            int a = d < j ? d : j;
            if (d == -1)
            {
                a = j;
            }
            if (j == -1)
            {
                a = d;
            }
            for (int i = a-1; i >= 0; i--)
            {
                newstr += str[i];
            }
            newstr += str[a];
            str= str.Remove(0, a+1);
        }
        print("输入：" + brr + "输出：" + newstr);
        return newstr;
    }
}
