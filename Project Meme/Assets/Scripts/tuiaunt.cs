using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tuiaunt : MonoBehaviour
{
    // Start is called before the first frame update
    public bool istrigger = false;
    public Item targetItem;
    public GameObject tui;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)&&istrigger&&InventoryManager.getSelect() == targetItem)
        {
            tui.SetActive(false);
            InventoryManager.DestroyItem(targetItem);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            istrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            istrigger = false;
        }
    }
}
