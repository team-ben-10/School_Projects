using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadBTN : MonoBehaviour
{
    public delegate void Call(int i);
    public Call Click;
    public int value;
    public void GetValue()
    {
        Debug.Log(value);
        Click?.Invoke(value);
    }
}
