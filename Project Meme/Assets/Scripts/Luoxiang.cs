using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Luoxiang : MonoBehaviour
{
    public string SceneName;
    
    private bool istrigger = false;

    public Item targetItem1;
    public Item targetItem2;

    public bool remain1 = true;
    public bool remain2 = true;

    public GameObject Gua;

    public GameObject video;

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
            }
            
            
            if(!(remain1||remain2))
//                video.SetActive(true);
//                video.GetComponent<VideoPlayer>().Play();
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
