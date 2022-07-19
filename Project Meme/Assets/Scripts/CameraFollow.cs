using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            if (transform.position != target.position)
            {
                Vector3 targetPos = new Vector3(Mathf.Max(target.position.x, 0), Mathf.Max(target.position.y, 0), target.position.z);
                transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
            }
        }
    }
}
