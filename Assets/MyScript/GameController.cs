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
        //親を取得して位置指定
        currentBlocks = Instantiate(twinBlocks);
        currentBlocks.transform.position = new Vector3(2, 11, 0);

        //ブロック1を取得して位置指定
        GameObject block1 = Instantiate(blocks[Random.Range(0, 4)]);
        block1.transform.position = new Vector3(2, 11, 0);
        //currentBlocks(twinBlocks)と親子関係にする
        block1.transform.SetParent(currentBlocks.transform, true);

        //ブロック2を取得して位置指定
        GameObject block2 = Instantiate(blocks[Random.Range(0, 4)]);
        block2.transform.position = new Vector3(2, 12, 0);
        //currentBlocks(twinBlocks)と親子関係にする
        block2.transform.SetParent(currentBlocks.transform, true);
    }
}
