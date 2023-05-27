using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //面倒なのでprivateは省略
    [SerializeField]GameObject obstaclePrefab;//障害物プレハブ
    Vector3 spawnPos = new Vector3(25,0,-2);//スポーンする場所
    float elapsedTims;
    PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        elapsedTims += Time.deltaTime;
        if(elapsedTims > 2.0f && !playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation);
            elapsedTims = 0.0f;
        }
        

    }
}
