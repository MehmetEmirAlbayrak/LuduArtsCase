using UnityEngine;
using Runtime.Core;

public class InteractionDetector : MonoBehaviour
{
    public Camera MainCamera { get; private set; }
    [SerializeField] private float m_InteractionRange = 2f;
    private void Awake()
    {
        MainCamera = Camera.main;
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
        Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, m_InteractionRange))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}