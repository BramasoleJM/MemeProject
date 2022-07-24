using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Luoxiang : MonoBehaviour
{
    public string SceneName;
    
    private bool istrigger = false;

    public Item targetItem1;
    public Item targetItem2;

    public GameObject Gua;

    public int remain = 2;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)&&istrigger)
        {
            if (InventoryManager.getSelect() == targetItem1)
            {
                remain--;
                InventoryManager.DestroyItem(targetItem1);
            }else if (InventoryManager.getSelect() == targetItem2)
            {
                remain--;
                InventoryManager.DestroyItem(targetItem2);
            }
            
            
            if(remain == 0)
                Gua.SetActive(true);
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
