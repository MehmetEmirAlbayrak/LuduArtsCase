using UnityEngine;
using Runtime.Core;

public class InteractionDetector : MonoBehaviour
{
    public Camera m_mainCamera;
    [SerializeField] private const float k_InteractionRange = 2f;
    private void Awake()
    {
        m_mainCamera = GetComponentInParent<Camera>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DetectInteractables();
        }
    }
    private void DetectInteractables()
    {
        Ray ray = m_mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, k_InteractionRange))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}