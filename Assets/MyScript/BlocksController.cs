using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.position += new Vector3(0, -1, 0);
        }
        //回転
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.RotateAround(transform.position, new Vector3(0, 0, 1), 90);
            //回転しても向きを同じにする
            foreach (Transform childBlock in transform)
            {
                childBlock.transform.RotateAround(childBlock.transform.position, new Vector3(0, 0, 1), -90);
            }
        }
    }
}
