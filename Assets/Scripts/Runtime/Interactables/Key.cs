using UnityEngine;
using Runtime.Core;

/// <summary>
/// Toplanabilir anahtar. Envantere eklenir ve uyumlu kapıyı açar.
/// </summary>
public class Key : MonoBehaviour, IInteractable
{
    #region Fields

    [SerializeField] private KeyType m_KeyType;

    #endregion

    #region Properties

    /// <summary>
    /// Bu anahtarın tipi (kapı eşleşmesi için).
    /// </summary>
    public KeyType KeyType => m_KeyType;

    #endregion

    #region Unity Methods

    private void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null && m_KeyType != null)
        {
            Material material = new Material(meshRenderer.material);
            material.color = m_KeyType.keyColor;
            meshRenderer.material = material;
        }
    }

    #endregion

    #region Interface Implementations

    /// <inheritdoc />
    public void Interact()
    {
        if (Inventory.Instance != null)
        {
            Inventory.Instance.AddItem(this);
        }
        gameObject.SetActive(false);
    }

    /// <inheritdoc />
    public void CancelInteract()
    {
    }

    /// <inheritdoc />
    public string ShowInteractionPrompt()
    {
        return "Press E to pick up the key";
    }

    /// <inheritdoc />
    public string OutOfRangeInteractionPrompt()
    {
        return "You are too far away to interact with the key";
    }

    /// <inheritdoc />
    public void HideInteractionPrompt()
    {
    }

    #endregion
}
