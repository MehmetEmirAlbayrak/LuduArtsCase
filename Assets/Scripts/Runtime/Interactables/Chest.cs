using UnityEngine;
using Runtime.Core;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private const float k_InteractTime = 2f;
    private bool isInteracting = false;
    private float interactTimer = 0f;
    [SerializeField] private Animator m_chestAnimator;
    public void Interact()
    {
        if (!isInteracting)
        {
            isInteracting = true;
            interactTimer = 0f;
        }
    }
    public void CancelInteract()
    {
        isInteracting = false;
        interactTimer = 0f;
    }
    private void Update()
    {
        if (isInteracting && m_chestAnimator.GetBool("isOpen") == false)
        {
            interactTimer += Time.deltaTime;
            if (interactTimer >= k_InteractTime)
            {
                isInteracting = false;
                Debug.Log("Chest interacted");
                m_chestAnimator.SetBool("isOpen", true);
            }
        }
    }
}