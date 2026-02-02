using UnityEngine;
using Runtime.Core;

/// <summary>
/// Aç/kapa (toggle) etkileşimli kol. Animasyon ve isteğe bağlı kapı kilidini açar.
/// </summary>
public class Switch : MonoBehaviour, IInteractable
{
    #region Fields

    [SerializeField] private Animator m_ObjectToToggle;
    [SerializeField] private Door m_DoorToUnlock;

    private bool m_IsOn;

    #endregion

    #region Unity Methods

    // (Boş – gerekirse Awake/Start eklenebilir)

    #endregion

    #region Interface Implementations

    /// <inheritdoc />
    public void Interact()
    {
        m_IsOn = !m_IsOn;
        if (m_ObjectToToggle != null)
        {
            m_ObjectToToggle.SetBool("isOn", m_IsOn);
        }
        if (m_DoorToUnlock != null)
        {
            m_DoorToUnlock.Unlock();
            m_DoorToUnlock.Interact();
        }
    }

    /// <inheritdoc />
    public void CancelInteract()
    {
    }

    /// <inheritdoc />
    public string ShowInteractionPrompt()
    {
        return "Press E to toggle the switch";
    }

    /// <inheritdoc />
    public string OutOfRangeInteractionPrompt()
    {
        return "You are too far away to interact with the switch";
    }

    /// <inheritdoc />
    public void HideInteractionPrompt()
    {
    }

    #endregion
}
