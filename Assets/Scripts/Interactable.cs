using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public interface IUsable
{
    void Use();
}
public class Interactable : MonoBehaviour , IUsable
{

    public void Use()
    {
        Debug.Log("Coucou");
    }

    //public void Use()
    //{
        //throw new System.NotImplementedException();
    //}
}
