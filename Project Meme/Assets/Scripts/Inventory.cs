using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    public int hold = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            hold = 0;
        }else if (Input.GetKey(KeyCode.Alpha2))
        {
            hold = 1;
        }
        else if(Input.GetKey(KeyCode.Alpha3))
        {
            hold = 2;
        }else if (Input.GetKey(KeyCode.Alpha4))
        {
            hold = 4;
        }
        
        
    }
}
