using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KunKun : MonoBehaviour
{
    public string SceneName;
    
    private bool istrigger = false;

    public Item targetItem1;
    public Item targetItem2;
    public Item targetItem3;
    public Item targetItem4;

    public bool remain1 = true;
    public bool remain2 = true;
    public bool remain3 = true;
    public bool remain4 = true;
    
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)&&istrigger)
        {
            if (InventoryManager.getSelect() == targetItem1)
            {
                remain1 = false;
                InventoryManager.DestroyItem(targetItem1);
            }else if (InventoryManager.getSelect() == targetItem2)
            {
                remain2 = false;
                InventoryManager.DestroyItem(targetItem2);
            }else if (InventoryManager.getSelect() == targetItem3)
            {
                remain3 = false;
                InventoryManager.DestroyItem(targetItem3);
            }else if (InventoryManager.getSelect() == targetItem4)
            {
                remain4 = false;
                InventoryManager.DestroyItem(targetItem4);
            }
            
            if(!(remain1||remain2||remain3||remain4))
                SceneManager.LoadScene(SceneName);
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
    // Start is called before the first frame update
    
}
