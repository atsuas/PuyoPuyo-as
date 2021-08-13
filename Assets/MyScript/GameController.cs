using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] blocks;
    
    void Start()
    {
        CreateBlocks();
    }

    void Update()
    {
        
    }

    void CreateBlocks()
    {
        GameObject block1 = Instantiate(blocks[Random.Range(0, 4)]);
        block1.transform.position = new Vector3(2, 11, 0);
        GameObject block2 = Instantiate(blocks[Random.Range(0, 4)]);
        block2.transform.position = new Vector3(2, 12, 0);
    }
}
