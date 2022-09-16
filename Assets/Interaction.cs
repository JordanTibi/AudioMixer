using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
   
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red);

        var myLayerMask = LayerMask.GetMask("Joueur", "Default");

        if(Physics.Raycast(transform.position, transform.forward, out var hitinfo, 2f))
        {

        }
    }
}
