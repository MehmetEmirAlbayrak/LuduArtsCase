using UnityEngine;
using UnityEngine.UI;
using Runtime.Core;

public class InteractionPrompt : MonoBehaviour
{
    [SerializeField] private Text m_interactionPromptText;
    public void ShowInteractionPrompt(string prompt)
    {
        m_interactionPromptText.text = prompt;
    }
    public void HideInteractionPrompt()
    {
        m_interactionPromptText.text = "";
    }
}