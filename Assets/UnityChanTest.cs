using UnityEngine;
using System.Collections;

// ユニティちゃんの動作テスト
public class UnityChanTest : MonoBehaviour {
    Animator animator;

    // スタート時に呼ばれる
    void Start() {
        animator = GetComponent<Animator>();
    }

    // 定期時間毎に呼ばれる
    void FixedUpdate() {
        // 前進
        if (Input.GetKey("up")) {
            transform.position += transform.forward * 0.05f;
            animator.SetBool("isRunning", true);
        }else if (Input.GetKey("down")) {
            // 後退
            transform.position += transform.forward * -0.05f;
            animator.SetBool("isRunning", true);
        } else {
            animator.SetBool("isRunning", false);
        }

        // 左右回転
        if (Input.GetKey("left")) {
            transform.Rotate(0, -5, 0);
        } else if (Input.GetKey("right")) {
            transform.Rotate(0, 5, 0);
        }
    }
}
