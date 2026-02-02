using UnityEngine;
using TMPro;
using Runtime.Core;

/// <summary>
/// Etkileşim mesajlarını (prompt, menzil dışı) UI'da gösterir.
/// </summary>
public class InteractionPrompt : MonoBehaviour
{
    #region Fields

    [SerializeField] private TextMeshProUGUI m_InteractionPromptText;

    #endregion

    #region Properties

    /// <summary>
    /// Singleton prompt örneği.
    /// </summary>
    public static InteractionPrompt Instance { get; private set; }

    #endregion

    #region Unity Methods

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Menzil içindeyken gösterilecek etkileşim mesajını yazar.
    /// </summary>
    /// <param name="interactable">Etkileşimli nesne (mesajı bu nesneden alınır).</param>
    public void ShowInteractionPrompt(IInteractable interactable)
    {
        if (m_InteractionPromptText != null && interactable != null)
        {
            m_InteractionPromptText.text = "<color=yellow>" + interactable.ShowInteractionPrompt() + "</color>";
        }
    }

    /// <summary>
    /// Etkileşim mesajını gizler.
    /// </summary>
    public void HideInteractionPrompt()
    {
        if (m_InteractionPromptText != null)
        {
            m_InteractionPromptText.text = string.Empty;
        }
    }

    /// <summary>
    /// Menzil dışı mesajını gösterir.
    /// </summary>
    /// <param name="interactable">Etkileşimli nesne.</param>
    public void ShowOutOfRangeInteractionPrompt(IInteractable interactable)
    {
        if (m_InteractionPromptText != null && interactable != null)
        {
            m_InteractionPromptText.text = "<color=red>" + interactable.OutOfRangeInteractionPrompt() + "</color>";
        }
    }

    #endregion
}
