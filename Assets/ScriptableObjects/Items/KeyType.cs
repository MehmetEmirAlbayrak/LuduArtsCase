using UnityEngine;

[CreateAssetMenu(fileName = "NewKeyType", menuName = "Game/Key Type")]
public class KeyType : ScriptableObject
{
    [Tooltip("Gösterilen isim (örn: Mavi Anahtar)")]
    public string displayName = "Anahtar";

    [Tooltip("Renk / tip ayırımı için")]
    public Color keyColor = Color.white;
}