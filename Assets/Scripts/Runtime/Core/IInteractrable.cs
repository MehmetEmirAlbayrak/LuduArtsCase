namespace Runtime.Core
{
    public interface IInteractable
    {
        void Interact();
        void CancelInteract() { }
        string ShowInteractionPrompt();
        string OutOfRangeInteractionPrompt();
        void HideInteractionPrompt();
    }
}