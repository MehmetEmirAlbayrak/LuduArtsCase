using UnityEngine;
using Runtime.Core;
using UnityEngine.Timeline;

public class Key : MonoBehaviour, IInteractable
{
    [SerializeField] private KeyType m_keyType;
    public KeyType KeyType
    {
        get { return m_keyType; }
    }
    private void Start()
    {
        var material = new Material(gameObject.GetComponent<MeshRenderer>().material);
        material.color = m_keyType.keyColor;
        gameObject.GetComponent<MeshRenderer>().material = material;
    }
    public void Interact()
    {
        Inventory.Instance.AddItem(this);
        gameObject.SetActive(false);
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