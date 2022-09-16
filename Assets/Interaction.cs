using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
   
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red);

        //var myLayerMask = LayerMask.GetMask("Joueur", "Default");

        //RaycastHit[] hits = Physics.RaycastAll(transform.position, transform.forward, 2f);


        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 2f))
        {
            Debug.Log($"J'ai touché quelqu'un {hitInfo.collider.name}");
            if(hitInfo.collider.TryGetComponent<IUsable>(out var interactable))
            {
                interactable.Use();

                
            }

        }


    }
}
