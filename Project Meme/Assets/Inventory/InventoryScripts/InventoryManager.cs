using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
   private static InventoryManager instance;
   public Inventory myBag;
   public GameObject slotGrid;
   public slot slotPrefab;

   void Awake()
   {
      if(instance != null)
         Destroy(this);
      instance = this;
   }

   private void OnEnable()
   {
      RefreshItem();
   }

   //i can't understand, just copy
   public static void CreateNewItem(Item item)
   {
      slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
      newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
      newItem.slotItem = item;
      newItem.slotImage.sprite = item.image;
      
   }

   public static void RefreshItem()
   {
      for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
      {
         Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
      }

      for (int i = 0; i < instance.myBag.ItemList.Count; i++)
      {
         CreateNewItem(instance.myBag.ItemList[i]);
      }
   }
}