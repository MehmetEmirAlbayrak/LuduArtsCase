using UnityEngine;
using Runtime.Core;

/// <summary>
/// Basılı tutma (hold) ile açılan sandık. Belirli süre E basılı tutulmalıdır.
/// </summary>
public class Chest : MonoBehaviour, IInteractable
{
    #region Fields

    private const float k_InteractTime = 2f;

    [SerializeField] private float m_InteractTime = k_InteractTime;
    [SerializeField] private Animator m_ChestAnimator;

    private bool m_IsInteracting;
    private float m_InteractTimer;

    #endregion

    #region Unity Methods

    private void Update()
    {
        if (!m_IsInteracting || (m_ChestAnimator != null && m_ChestAnimator.GetBool("isOpen")))
        {
            return;
        }

        m_InteractTimer += Time.deltaTime;
        if (m_InteractTimer >= m_InteractTime)
        {
            m_IsInteracting = false;
            m_InteractTimer = 0f;
            if (m_ChestAnimator != null)
            {
                m_ChestAnimator.SetBool("isOpen", true);
            }
        }
    }

    #endregion

    #region Interface Implementations

    /// <inheritdoc />
    public void Interact()
    {
        if (!m_IsInteracting)
        {
            m_IsInteracting = true;
            m_InteractTimer = 0f;
        }
    }

    /// <inheritdoc />
    public void CancelInteract()
    {
        m_IsInteracting = false;
        m_InteractTimer = 0f;
    }

    /// <inheritdoc />
    public string ShowInteractionPrompt()
    {
        return "Press E to open the chest";
    }

    /// <inheritdoc />
    public string OutOfRangeInteractionPrompt()
    {
        return "You are too far away to interact with the chest";
    }

    /// <inheritdoc />
    public void HideInteractionPrompt()
    {
    }

    #endregion
}
