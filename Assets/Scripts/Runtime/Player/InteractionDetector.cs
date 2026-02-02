using UnityEngine;
using Runtime.Core;

/// <summary>
/// Oyuncunun bakış yönünde etkileşimli nesneleri tespit eder ve E tuşu ile etkileşimi tetikler.
/// </summary>
public class InteractionDetector : MonoBehaviour
{
    #region Fields

    private const float k_InteractionRange = 2f;
    private const float k_OutOfRangeDistance = 5f;

    [SerializeField] private float m_InteractionRange = k_InteractionRange;
    [SerializeField] private float m_OutOfRangeDistance = k_OutOfRangeDistance;

    private Camera m_MainCamera;
    private IInteractable m_CurrentInteractable;
    private bool m_IsInteracting;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        m_MainCamera = Camera.main;
    }

    private void Update()
    {
        RayCastInteraction(Input.GetKeyDown(KeyCode.E));

        if (Input.GetKeyUp(KeyCode.E) && m_CurrentInteractable != null)
        {
            m_CurrentInteractable.CancelInteract();
            m_CurrentInteractable = null;
        }
    }

    #endregion

    #region Methods

    private void RayCastInteraction(bool isEPressed)
    {
        Ray ray = m_MainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, m_OutOfRangeDistance))
        {
            var interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                float distance = Vector3.Distance(m_MainCamera.transform.position, hit.point);
                m_CurrentInteractable = interactable;

                if (isEPressed)
                {
                    if (distance <= m_InteractionRange)
                    {
                        m_CurrentInteractable.Interact();
                        InteractionPrompt.Instance.HideInteractionPrompt();
                    }
                }
                else if (distance > m_InteractionRange && distance <= m_OutOfRangeDistance)
                {
                    InteractionPrompt.Instance.ShowOutOfRangeInteractionPrompt(m_CurrentInteractable);
                }
                else
                {
                    InteractionPrompt.Instance.ShowInteractionPrompt(m_CurrentInteractable);
                }
            }
        }
        else if (m_CurrentInteractable != null)
        {
            m_CurrentInteractable = null;
            InteractionPrompt.Instance.HideInteractionPrompt();
        }
    }

    #endregion
}
