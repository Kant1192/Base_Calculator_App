using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputExample : MonoBehaviour
{

    public Text text;
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetText()
    {
        //
        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();
        //Text型をstring型に変換
        string name = inputText.text;
        Debug.Log(name);

        /*
        inputText.text = "";
        Debug.Log("InputText" + inputText.text);
        文字列消去の失敗例
        */

        //成功例
        InputField form = GameObject.Find("InputField").GetComponent<InputField>();
        form.text = "";
    }

 
    public void InputText()
    {
        //テキスト(UI)にinputFieldの内容を反映する
        text.text = inputField.text;
    }
}
