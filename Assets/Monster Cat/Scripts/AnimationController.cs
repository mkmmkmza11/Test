using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mAnimator != null)
        {
            if(Input.GetKeyDown(KeyCode.Y))
            {
                mAnimator.SetTrigger("TakeDamage");
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                mAnimator.SetTrigger("Dead");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                mAnimator.SetTrigger("Taunt");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                mAnimator.SetTrigger("UseSkill");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                mAnimator.SetTrigger("Idle");
            }

        }
    }
}
