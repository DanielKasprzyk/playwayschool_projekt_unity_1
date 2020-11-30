using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionComponent : MonoBehaviour
{
    private Interactable interactable;
    void Start()
    {
        interactable = null;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactable != null)
        {
            if (interactable.CanInteract(transform))
            {
                interactable.Interact();
            }
        }
    }


    void OnTriggerEnter(Collider collider)
    {
        interactable = collider.gameObject.GetComponent<Interactable>();
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.GetComponent<Interactable>() != null)
        {
            interactable = null;
        }
    }
}
