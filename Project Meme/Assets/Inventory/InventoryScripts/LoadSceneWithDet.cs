using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneWithDet : MonoBehaviour
{
    public string SceneName;
    
    private bool istrigger = false;

    public Item targetItem;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)&&istrigger&&InventoryManager.getSelect() == targetItem)
        {
            SceneManager.LoadScene(SceneName);
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
