using UnityEngine;
using TMPro;
using Runtime.Core;

public class InteractionPrompt : MonoBehaviour
{
    public static InteractionPrompt Instance;
    
    [SerializeField] private TextMeshProUGUI m_interactionPromptText;

    private void Awake()
    {
        Instance = this;
    }
      public void ShowInteractionPrompt(IInteractable interactable)
    {
        m_interactionPromptText.text = "<color=yellow>" + interactable.ShowInteractionPrompt() + "</color>";
    }
    public void HideInteractionPrompt()
    {
        m_interactionPromptText.text = "";
    }
    public void ShowOutOfRangeInteractionPrompt(IInteractable interactable)
    {
        m_interactionPromptText.text = "<color=red>" + interactable.OutOfRangeInteractionPrompt() + "</color>";
    }
}