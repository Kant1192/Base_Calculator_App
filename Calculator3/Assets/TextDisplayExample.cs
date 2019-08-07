using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayExample : MonoBehaviour
{
    public InputField inputField;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InputText()
    {
        //text(UI)にinputFieldの内容を表示する
        text.text = inputField.text;
    }
}
