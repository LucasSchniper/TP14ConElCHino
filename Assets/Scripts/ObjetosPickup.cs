using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosPickup : MonoBehaviour
{
    
    public CollectibleMa manager;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            if (manager != null)
                manager.AddCollectible();

            
            Destroy(gameObject);
        }
    }
}
