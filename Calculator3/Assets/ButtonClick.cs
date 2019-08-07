using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World!");
    }
    public void OnClick()
    {
        Debug.Log("Hello World!");
    }
    public void InputExample()
    {
        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();
        string name = inputText.text;
        Debug.Log(name);
    }
}
