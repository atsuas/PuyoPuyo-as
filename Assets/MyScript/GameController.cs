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
        StartCoroutine(Array());
    }

    //コルーチンで確認
    IEnumerator Array()
    {
        for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                yield return new WaitForSeconds(0.3f);
                GameObject piece = Instantiate(blocks[Random.Range(0, 4)]);
                piece.transform.position = new Vector3(x, y, 0);
                fieldBlocks[x, y] = piece;
            }
        }
    }

    void Update()
    {
        
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
