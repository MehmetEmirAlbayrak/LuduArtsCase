using UnityEngine;
using Runtime.Core;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private const float k_InteractTime = 2f;
    private bool isInteracting = false;
    private float interactTimer = 0f;
    public void Interact()
    {
        isInteracting = true;
        interactTimer = 0f;
    }
    private void Update()
    {
        if (isInteracting)
        {
            interactTimer += Time.deltaTime;
            if (interactTimer >= k_InteractTime)
            {
                isInteracting = false;
                Debug.Log("Chest interacted");
            }
        }
    }
}