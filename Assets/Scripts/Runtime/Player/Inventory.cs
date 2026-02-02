using UnityEngine;
using System.Collections.Generic;
using Runtime.Core;


public class Inventory : MonoBehaviour
{
    public List<IInteractable> items = new List<IInteractable>();
    public void AddItem(IInteractable item)
    {
        items.Add(item);
    }
}