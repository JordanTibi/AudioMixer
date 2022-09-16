using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EntityInteraction : MonoBehaviour
{

  

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2f);
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 2f))
        {
            if(hitInfo.collider.TryGetComponent<IUsable>(out IUsable usableComponent))
            {
                usableComponent.Use();
            }
        }
    }

}
