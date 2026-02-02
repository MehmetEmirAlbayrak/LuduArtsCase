using UnityEngine;
using Runtime.Core;

public class Key : MonoBehaviour, IInteractable
{
    [SerializeField] private Inventory inventory;

    public void Interact()
    {
        Debug.Log("Key interacted");
        inventory.AddItem(this);
        Destroy(gameObject);
    }
}