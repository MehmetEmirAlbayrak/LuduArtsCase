using UnityEngine;
using Runtime.Core;

public class InteractionDetector : MonoBehaviour
{
    private const float k_InteractionRange = 2f;
    [SerializeField] private float m_interactionRange = k_InteractionRange;
    private const float k_OutOfRangeDistance = 5f;
    [SerializeField] private float m_outOfRangeDistance = k_OutOfRangeDistance;
    private Camera m_mainCamera;
    private IInteractable m_currentInteractable;
    private bool m_isInteracting = false;
    private void Awake()
    {
        m_mainCamera = Camera.main;
    }
    private void Update()
    {
       
        RayCastInteraction(Input.GetKeyDown(KeyCode.E));
        
        if (Input.GetKeyUp(KeyCode.E) && m_currentInteractable != null)
        {
            m_currentInteractable.CancelInteract();
            m_currentInteractable = null;
        }
    }
    private void RayCastInteraction(bool isEPressed)
    {
        var ray = m_mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, m_outOfRangeDistance))
        {
            var interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                var distance = Vector3.Distance(m_mainCamera.transform.position, hit.point);
                m_currentInteractable = interactable;
                if (isEPressed)
                {
                    if (distance <= m_interactionRange)
                    {
                        m_currentInteractable.Interact();
                        InteractionPrompt.Instance.HideInteractionPrompt();
                    }
                   
                }
                else if (distance > m_interactionRange && distance <= m_outOfRangeDistance)
                {
                    InteractionPrompt.Instance.ShowOutOfRangeInteractionPrompt(m_currentInteractable);
                }
                else
                {
                    InteractionPrompt.Instance.ShowInteractionPrompt(m_currentInteractable);
                }

            }
        }
        else if (m_currentInteractable != null)
        {
            m_currentInteractable = null;
            InteractionPrompt.Instance.HideInteractionPrompt();
        }
    }
}