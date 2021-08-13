using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject twinBlocks;
    GameObject currentBlocks;
    public GameObject[,] fieldBlocks;
    
    void Start()
    {
        fieldBlocks = new GameObject[6, 13];
        //CreateBlocks();
        BlockArray();
        Debug.Log(BlockConnect(1, 1, 0));
    }

    void BlockArray()
    {
        for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                GameObject piece = Instantiate(blocks[Random.Range(0, 4)]);
                piece.transform.position = new Vector3(x, y, 0);
                fieldBlocks[x, y] = piece;
            }
        }
    }

    int BlockConnect(int x, int y, int blockConnect)
    {
        //自分自身を数える
        blockConnect++;
        //右にあれば+1数える
        if (fieldBlocks[x, y].name == fieldBlocks[x + 1, y].name)
        {
            blockConnect++;
        }
        return blockConnect;
    }

    public void CreateBlocks()
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
