using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject twinBlocks;
    GameObject currentBlocks;
    
    void Start()
    {
        CreateBlocks();
    }

    void Update()
    {
        
    }

    void CreateBlocks()
    {
        currentBlocks = Instantiate(twinBlocks);
        currentBlocks.transform.position = new Vector3(2, 11, 0);

        GameObject block1 = Instantiate(blocks[Random.Range(0, 4)]);
        block1.transform.position = new Vector3(2, 11, 0);
        block1.transform.SetParent(currentBlocks.transform, true);

        GameObject block2 = Instantiate(blocks[Random.Range(0, 4)]);
        block2.transform.position = new Vector3(2, 12, 0);
        block2.transform.SetParent(currentBlocks.transform, true);
    }
}
