using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    private Animator mAnimator;

    public bool[] onetime;

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
                if (!onetime[0])
                {
                    onetime[0] = true;
                    mAnimator.SetTrigger("TakeDamage");
                    GameManager.instance.TakeDamageAnim = false;
                    if(GameManager.instance.TakeDamageAnim == false)
                    {
                        onetime[0] = false;
                    }
                    
                }
                

            }
            if (GameManager.instance.DeadAnim)
            {
                if (!onetime[1])
                {
                    onetime[1] = true;
                    mAnimator.SetTrigger("Dead");
                    
                    if (GameManager.instance.DeadAnim == false)
                    {
                        onetime[1] = false;
                    }


                }
               
            }
            if (GameManager.instance.isCount)
            {
                if (!onetime[2])
                {
                    onetime[2] = true;
                    mAnimator.SetTrigger("Taunt");

                    if (GameManager.instance.isCount == false)
                    {
                        onetime[2] = false;
                    }


                }
            }

            if (GameManager.instance.UseSkillAnim)
            {
                if (!onetime[3])
                {
                    onetime[3] = true;
                    mAnimator.SetTrigger("UseSkill");
                    GameManager.instance.UseSkillAnim = false;
                    if (GameManager.instance.UseSkillAnim == false)
                    {
                        onetime[3] = false;
                    }

                }
            }

        }
    }
}
