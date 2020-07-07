using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    void Awake() {
        animator = GetComponent<Animator> ();    
    }
    void OnCollisionEnter2D(Collision2D target) {
        if (target.gameObject.tag == "Obstacle"){
            animator.Play("Idle");
        }
    }
    void OnCollisionExit2D(Collision2D target) {
        if (target.gameObject.tag == "Obstacle"){
            animator.Play("Run");
        }
    }
}
