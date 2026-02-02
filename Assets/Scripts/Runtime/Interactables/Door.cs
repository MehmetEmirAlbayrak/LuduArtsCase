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
        Debug.Log("Door interacted");
        if (m_isLocked)
        {
            if (Inventory.Instance.items.Any(item => (item as Key).KeyType == m_requiredKeyType))
            {
                Unlock();
                Debug.Log("Door is unlocked");
            }
            else
            {
                Debug.Log("Door is locked");
            }
        }
        else
        {
            Unlock();
            Debug.Log("Door is unlocked");
        }
    }
    public void CancelInteract()
    {
    }

    public void Unlock()
    {
        m_isLocked = false;
        Debug.Log("Door is unlocked");
        m_doorAnimator.SetBool("isOpen", true);
    }
}