using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
   private static InventoryManager instance;
   public Inventory myBag;
   public GameObject slotGrid;
   public slot slotPrefab;

   public Item select;

   void Awake()
   {
      if(instance != null)
         Destroy(this);
      instance = this;
   }

   private void OnEnable()
   {
      RefreshItem();
      instance.select = new Item();
   }

   public static void UpdateSelect(int i)
   {
      Debug.Log("item "+i+" Selected.");
      if (instance.myBag.ItemList.Count > i)
      {
         instance.select = instance.myBag.ItemList[i];
      }
      else
      {
         instance.select = new Item();
      }
      
   }

   public static Item getSelect()
   {
      return instance.select;
   }

   //i can't understand, just copy
   public static void CreateNewItem(Item item)
   {
      slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
      newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
      newItem.slotItem = item;
      newItem.slotImage.sprite = item.image;
      
   }

   public static void DestroyItem(Item item)
   {
      instance.myBag.ItemList.Remove(item);
      RefreshItem();
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
