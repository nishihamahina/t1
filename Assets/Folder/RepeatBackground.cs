using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピートの開始位置
    void Start()
    {
        startPos = transform.position;//ゲーム開発時の場所を記録
    }

    // Update is called once per frame
    void Update()
    {
        //何か条件を満たしたら
        if (startPos.x - transform.position.x > 10.0f)
        {
            transform.position = startPos;
        }
    }
}
