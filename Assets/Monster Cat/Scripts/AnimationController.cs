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
            if(GameManager.instance.TakeDamageAnim)
            {
                mAnimator.SetTrigger("TakeDamage");
            }
            if (GameManager.instance.DeadAnim)
            {
                mAnimator.SetTrigger("Dead");
            }
            if (GameManager.instance.isCount)
            {
                mAnimator.SetTrigger("Taunt");
            }
            if (GameManager.instance.UseSkillAnim)
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
