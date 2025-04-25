using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField] private float pickupRange = 3f;
    [SerializeField] private Camera cameramain;
    public InvetoryManager invetoryManager;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryPickItem();
        }
    }

    void TryPickItem()
    {
        Ray ray = new Ray(cameramain.transform.position, cameramain.transform.forward);
        if(Physics.Raycast(ray, out RaycastHit hit, pickupRange))
        {
            ItemPickup item = hit.collider.gameObject.GetComponent<ItemPickup>();
            if(item != null )
            {
                invetoryManager.AddItem(item);
                Destroy(item.gameObject);
            }
        }
    }

}
