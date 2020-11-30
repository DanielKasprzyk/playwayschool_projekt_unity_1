using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float maxInteractionDistance = 2f;

    public virtual bool CanInteract(Transform player)
    {
        return (player != null && Vector3.Distance(transform.position, player.transform.position) <= maxInteractionDistance);
    }

    public virtual void Interact()
    {
        Debug.Log("Interakcja");
    }
}
