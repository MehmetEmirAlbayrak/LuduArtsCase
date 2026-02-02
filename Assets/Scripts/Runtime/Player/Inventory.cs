using UnityEngine;
using System.Collections.Generic;
using Runtime.Core;


public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }
    public List<IInteractable> items = new List<IInteractable>();

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

    public void AddItem(IInteractable item)
    {
        items.Add(item);
    }
}