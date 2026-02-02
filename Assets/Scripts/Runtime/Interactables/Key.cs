using UnityEngine;
using Runtime.Core;

public class Key : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Key interacted");
    }
}