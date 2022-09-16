using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public string GetName()
    {
        return "Button1";
    }

    public void Use()
    {
        Debug.Log("Je suis un boutton");
    }
}
