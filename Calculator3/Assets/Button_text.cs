using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_text : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public InputField inputField;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Check()
    {
        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();
    }

}
