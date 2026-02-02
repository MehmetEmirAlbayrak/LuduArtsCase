using UnityEngine;
using Runtime.Core;
using System.Linq;
using Unity.VisualScripting;
using System;

public class Door : MonoBehaviour, IInteractable
{

    [SerializeField] private bool m_isLocked = true;
    [SerializeField] private KeyType m_requiredKeyType;
    [SerializeField] private Animator m_doorAnimator;

    public void Interact()
    {
        if (m_isLocked)
        {
            if (Inventory.Instance.items.Any(item => (item as Key).KeyType == m_requiredKeyType))
            {
                Unlock();
            }
            
        }
        else
        {
            Unlock();
        }
    }
    
    public void Unlock()
    {
        m_isLocked = false;
        m_doorAnimator.SetBool("isOpen", true);
    }
    public string ShowInteractionPrompt()
    {
        return "Press E to open the door";
    }
    public void HideInteractionPrompt()
    {
        return ;
    }
    public string OutOfRangeInteractionPrompt()
    {
        return "You are too far away to interact with the door";
    }
}