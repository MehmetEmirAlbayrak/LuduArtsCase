using UnityEngine;
using Runtime.Core;

public class InteractionDetector : MonoBehaviour
{
    [SerializeField] private const float k_InteractionRange = 2f;
    private Camera m_mainCamera;
    private IInteractable m_currentInteractable;
    private bool m_isInteracting = false;
    private void Awake()
    {
        m_mainCamera = Camera.main;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteractable();
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            if (m_currentInteractable != null)
            {
                m_currentInteractable.CancelInteract();
                m_currentInteractable = null;
            }
        }
    }
    private void TryInteractable()
    {
        var ray = m_mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, k_InteractionRange))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                m_currentInteractable = interactable;
                m_currentInteractable.Interact();
                InteractionPrompt.Instance.ShowInteractionPrompt(m_currentInteractable);
            }
        }
        
    }
}