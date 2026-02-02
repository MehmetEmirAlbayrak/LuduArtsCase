using UnityEngine;

/// <summary>
/// Anahtar / kilit tipi tanımı. Kapı ve anahtar eşleşmesi için kullanılır.
/// </summary>
[CreateAssetMenu(fileName = "NewKeyType", menuName = "Game/Key Type")]
public class KeyType : ScriptableObject
{
    /// <summary>
    /// Gösterilen isim (örn: Mavi Anahtar).
    /// </summary>
    [Tooltip("Gösterilen isim (örn: Mavi Anahtar)")]
    public string displayName = "Anahtar";

    /// <summary>
    /// Renk / tip ayırımı için kullanılan renk.
    /// </summary>
    [Tooltip("Renk / tip ayırımı için")]
    public Color keyColor = Color.white;
}
