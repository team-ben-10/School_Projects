using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Keypad : MonoBehaviour
{
    TMPro.TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        Keypad.instance.OnButtonClick(Keypad_Click);
        text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void Keypad_Click(int value)
    {
        if (value == -1)
        {
            text.text = text.text.Substring(0, text.text.Length - 1);
        }
        else
        {
            text.text += value + "";
        }
    }
}
