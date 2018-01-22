using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //発展課題

    //mpを消費して魔法攻撃をするMagic関数を作ってください
    public void Magic()
    {
        //int型の変数mpを宣言し、53で初期化してください
        int mp = 53;
        //Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
        for(; mp>=0;)
        {
            mp -= 5;
            if ( mp >= 0)
            { 
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }
}


public class Test : MonoBehaviour
{

    void Start()
    {   //課題
        int[] array = { 1, 3, 5, 7, 9 };
        for (int b = 0; b < 5; b++)
        {
            Debug.Log(array[b]);
        }


        for (int a = 4; a >=0; a--)
        {
            Debug.Log(array[a]);
        }

     //発展課題
     Boss boss = new Boss();
     boss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
