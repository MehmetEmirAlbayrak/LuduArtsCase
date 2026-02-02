using UnityEngine;
using Runtime.Core;
using System.Linq;

/// <summary>
/// Açılıp kapanabilen, anahtar ile kilitlenebilen kapı.
/// </summary>
public class Door : MonoBehaviour, IInteractable
{
    #region Fields

    [SerializeField] private bool m_IsLocked = true;
    [SerializeField] private KeyType m_RequiredKeyType;
    [SerializeField] private Animator m_DoorAnimator;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        SkinnedMeshRenderer renderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if (renderer != null && m_RequiredKeyType != null)
        {
            Material material = new Material(renderer.material);
            material.color = m_RequiredKeyType.keyColor;
            renderer.material = material;
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Kapıyı kilitsiz hale getirir ve açık animasyonunu tetikler.
    /// </summary>
    public void Unlock()
    {
        if (m_DoorAnimator != null)
        {
            m_DoorAnimator.SetBool("isOpen", true);
        }
    }
    public void Lock()
    {
        if (m_DoorAnimator != null)
        {
            m_DoorAnimator.SetBool("isOpen", false);
        }
    }

    #endregion

    #region Interface Implementations

    /// <inheritdoc />
    public void Interact()
    {
        if (m_IsLocked)
        {
            if (Inventory.Instance != null &&
                Inventory.Instance.Items.Any(item => item is Key key && key.KeyType == m_RequiredKeyType))
            {
                Unlock();
            }
        }
        else
        {
            Unlock();
        }
    }

    /// <inheritdoc />
    public void CancelInteract()
    {
    }

    /// <inheritdoc />
    public string ShowInteractionPrompt()
    {
        return "Press E to open the door";
    }

    /// <inheritdoc />
    public string OutOfRangeInteractionPrompt()
    {
        return "You are too far away to interact with the door";
    }

    /// <inheritdoc />
    public void HideInteractionPrompt()
    {
    }

    #endregion
}
