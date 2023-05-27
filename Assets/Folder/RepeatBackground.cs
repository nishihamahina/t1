using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピートの開始位置
    float repeatWidth;
    void Start()
    {
        startPos = transform.position;//ゲーム開発時の場所を記録
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //何か条件を満たしたら
        if ( transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
