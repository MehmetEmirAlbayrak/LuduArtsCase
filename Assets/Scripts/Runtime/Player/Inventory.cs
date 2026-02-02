using UnityEngine;
using System.Collections.Generic;
using Runtime.Core;

/// <summary>
/// Oyuncunun topladığı etkileşimli nesneleri (örn. anahtarlar) tutan basit envanter.
/// </summary>
public class Inventory : MonoBehaviour
{
    #region Fields

    [SerializeField] private List<IInteractable> m_Items = new List<IInteractable>();

    #endregion

    #region Properties

    /// <summary>
    /// Singleton envanter örneği.
    /// </summary>
    public static Inventory Instance { get; private set; }

    /// <summary>
    /// Envanterdeki öğe listesi.
    /// </summary>
    public List<IInteractable> Items => m_Items;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Envantere öğe ekler.
    /// </summary>
    /// <param name="item">Eklenecek etkileşimli nesne.</param>
    public void AddItem(IInteractable item)
    {
        if (item == null)
        {
            Debug.LogWarning("Inventory.AddItem: item is null.");
            return;
        }
        m_Items.Add(item);
    }

    #endregion
}
