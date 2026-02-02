namespace Runtime.Core
{
    /// <summary>
    /// Oyuncunun etkileşime girebileceği nesneler için temel arayüz.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// Nesne ile etkileşimi tetikler.
        /// </summary>
        void Interact();

        /// <summary>
        /// Basılı tutma (hold) etkileşimi iptal edilirse çağrılır.
        /// </summary>
        void CancelInteract();

        /// <summary>
        /// Menzil içindeyken gösterilecek etkileşim mesajını döndürür.
        /// </summary>
        /// <returns>Prompt metni.</returns>
        string ShowInteractionPrompt();

        /// <summary>
        /// Menzil dışındayken gösterilecek mesajı döndürür.
        /// </summary>
        /// <returns>Menzil dışı mesajı.</returns>
        string OutOfRangeInteractionPrompt();

        /// <summary>
        /// Etkileşim prompt'unun gizlenmesi gerektiğinde çağrılır.
        /// </summary>
        void HideInteractionPrompt();
    }
}
