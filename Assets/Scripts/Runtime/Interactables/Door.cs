using UnityEngine;
using Runtime.Core;
using System.Linq;

public class Door : MonoBehaviour, IInteractable
{

    [SerializeField] private bool m_isLocked = true;
    [SerializeField] private Inventory m_inventory;
    public void Interact()
    {
        Debug.Log("Door interacted");
        if (m_isLocked)
        {
            if (m_inventory.items.Any(item => item is Key))
            {
                m_isLocked = false;
                Debug.Log("Door is unlocked");
            }
            else
            {
                Debug.Log("Door is locked");
            }
        }
        else
        {
            Debug.Log("Door is unlocked");
        }
    }
}