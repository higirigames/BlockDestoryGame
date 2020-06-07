using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanController : MonoBehaviour
{
    Rigidbody rb;
    //Animatorを入れる変数
    private Animator animator;
    //ユニティちゃんの位置を入れる
    Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
        //ユニティちゃんのAnimatorにアクセスする
        animator = GetComponent<Animator>();
        //ユニティちゃんの現在より少し前の位置を保存
        playerPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //A・Dキー、←→キーで横移動
        float x = Input.GetAxisRaw("Horizontal") * 0.2f;

        //現在の位置＋入力した数値の場所に移動する
        //rb.MovePosition(transform.position + new Vector3(x, 0, 0));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + x, -13.5f, 13.5f), transform.position.y, transform.position.z);

        //ユニティちゃんの最新の位置から少し前の位置を引いて方向を割り出す
        Vector3 direction = transform.position - playerPos;

        if(direction.magnitude > 0.01f)
        {
            //入力方向を向かせる
            transform.rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, 0));
            //走るアニメーションを再生
            animator.SetBool("Running", true);
        }
        else{
            //移動していない時は走るアニメーションはオフ
            animator.SetBool("Running", false);
        }

        //ユニティちゃんの位置を更新する
        playerPos = transform.position;
    }
}
