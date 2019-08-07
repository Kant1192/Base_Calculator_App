using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Test02 : MonoBehaviour
{
    // Start is called before the first frame update
    //public Text InputText;
    public Text OutputText1;
    public Text OutputText2;
    public Text OutputText3;
    public Text OpenText;
    public InputField inputField;
    
    void Start()
    {
        //InputText = GameObject.Find("Message").GetComponent<Text>();
        var color1 = OutputText1.color;
        //color1.normalColor = 
    }

    // Update is called once per frame
    void Update()
    {   
    }


    /*
    やりたいこと
    ・入力したい数の進数が選択できる
    ・選択した数を2,10,16進数に変換
    ・
    ・
    */

    public void GetPushText()
    {
        //inputField = GameObject.Find("InputField").GetComponent<InputField>();
        //InputText = GameObject.Find("Message").GetComponent<Text>();
        //OutputText = GameObject.Find("Message").GetComponent<Text>();
        
        //入力
        string name = inputField.text;
        //int num = int.Parse(name);
        string binary_num = "", decimal_num = "", hexadecimal_num= "";

        //
        if (OpenText.text == "2進数を入力")
        {
            binary_num = name;
            //10進数に変換
            long num10 = Convert.ToInt32(name, 2);
            //binary_num = Convert.ToString(name);
            
            //10進数（文字列）に変換
            decimal_num = Convert.ToString(num10, 10);
            hexadecimal_num = Convert.ToString(num10, 16);
            

        } else if (OpenText.text == "10進数を入力")
        {
            int num = int.Parse(name);
            //string binary_num, octal_num, hexadecimal_num;

            //string decimal_num;
            //num *= 10;
            Debug.Log(num);
            //Debug.Log("TEST02 : " + name);

            //変換
            binary_num = Convert.ToString(num, 2);
            decimal_num = Convert.ToString(num, 8);
            //decimal_num = Convert.ToString(num, 10);
            hexadecimal_num = Convert.ToString(num, 16);


            //出力
        } else if (OpenText.text == "16進数を入力")
        {
            //16
            hexadecimal_num = name;

            //10進数に変換
            long num10 = Convert.ToInt32(name, 16);
            Debug.Log(num10);

            //10進数（文字列）に変換
            decimal_num = Convert.ToString(num10, 10);

            //2進数（文字列）に変換
            binary_num = Convert.ToString(num10, 2);
        } else
        {

        }

        OutputText1.text = binary_num;
        OutputText2.text = decimal_num;
        OutputText3.text = hexadecimal_num;
        //application-id:ca-app-pub-8339629169419358~2673800656(ca-app-pub-8339629169419358~2673800656)
        //広告ユニット:ca-app-pub-8339629169419358/7678715328
    }

}
