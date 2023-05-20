using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //面倒なのでprivateは省略
    [SerializeField]GameObject obstaclePrefab;//障害物プレハブ
    Vector3 spawnPos = new Vector3(25,0,0);//スポーンする場所
    float elapsedTims;
   
    void Update()
    {
        elapsedTims += elapsedTims.deltaTime;
        if(elapsedTims > 2.0f)
        {
            Instantiate(obstaclePrefab,spawnPos,obstaclePrefab,transform,rotation);
            elapsedTims;
        }
        

    }
}
