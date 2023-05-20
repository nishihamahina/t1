using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float gravituModifier;
    [SerializeField] float jumpforce;
    [SerializeField] bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravituModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されて、かつ、地面にいたら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);//じめんにじゃんぷしたら
            isOnGround = false;//ジャンプした＝地面にいない
        }
    }
    //衝突が起きたら
    private void OnCollisionEnter(Collision collision)
    {   //ぶつかった相手のタグがGroundだったら
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;//地面についている状態に変更
        }

    }
}
