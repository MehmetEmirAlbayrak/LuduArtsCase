using UnityEngine;
using Runtime.Core;

public class Key : MonoBehaviour, IInteractable
{

    public void Interact()
    {
        Debug.Log("Key interacted");
        Inventory.Instance.AddItem(this);
        Destroy(gameObject);
    }
    public void CancelInteract()
    {
    }
}