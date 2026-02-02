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
    public string ShowInteractionPrompt()
    {
        return "Press E to pick up the key";
    }
    public void HideInteractionPrompt()
    {
        return ;
    }
    public string OutOfRangeInteractionPrompt()
    {
        return "You are too far away to interact with the key";
    }
}