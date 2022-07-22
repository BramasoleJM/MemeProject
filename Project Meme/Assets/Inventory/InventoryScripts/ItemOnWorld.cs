using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemOnWorld : MonoBehaviour
{
    public Item thisItem;

    public Inventory playerInventory;
    public bool istrigger;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && istrigger)
        {
            AddNewItem();
        }
    }

    public void AddNewItem()
    {
        if (!playerInventory.ItemList.Contains(thisItem)&&playerInventory.ItemList.Count<4)
        {
            playerInventory.ItemList.Add(thisItem);
            Destroy(gameObject);
            //InventoryManager.CreateNewItem(thisItem);
        }
        
        InventoryManager.RefreshItem();
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger!!");
        if (other.gameObject.CompareTag("Player"))
        {
            istrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            istrigger = false;
        }
    }
}
