using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        this._animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isWalking = this._animator.GetBool("isWalking");

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            this._animator.SetBool("isWalking", true);
        }

        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            this._animator.SetBool("isWalking", false);
        }
    }
}
