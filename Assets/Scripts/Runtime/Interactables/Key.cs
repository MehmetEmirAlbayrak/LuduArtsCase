using UnityEngine;
using Runtime.Core;

public class Key : MonoBehaviour, IInteractable
{
    [SerializeField] private KeyType m_keyType;
    public KeyType KeyType
    {
        get { return m_keyType; }
    }
    public void Interact()
    {
        Debug.Log("Key interacted");
        Inventory.Instance.AddItem(this);
        gameObject.SetActive(false);
    }
    public void CancelInteract()
    {
    }
}