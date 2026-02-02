using UnityEngine;
using Runtime.Core;

public class Switch : MonoBehaviour, IInteractable
{
    private bool m_isOn = false;
    [SerializeField] private Animator m_objectToToggle;
    [SerializeField] private Door m_doorToUnlock;



    public void Interact()
    {
        Debug.Log("Switch interacted");
        m_isOn = !m_isOn;
        m_objectToToggle.SetBool("isOn", m_isOn);
        if (m_doorToUnlock != null)
        {
            m_doorToUnlock.Unlock();
            m_doorToUnlock.Interact();
        }
    }
    public void CancelInteract()
    {
    }
}