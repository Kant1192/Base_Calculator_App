using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test03 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text Opentext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick1()
    {
        Opentext.text = "2進数を入力";
    }
    public void OnClick2()
    {
        Opentext.text = "10進数を入力";
    }
    public void OnClick3()
    {
        Opentext.text = "16進数を入力";
    }
}
