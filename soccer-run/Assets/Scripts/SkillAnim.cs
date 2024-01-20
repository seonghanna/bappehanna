using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillAnim : MonoBehaviour
{
    public Animator animator_player;
    public Animator animator_ball;
    private bool shouldRotate = false;
    private bool shouldRotate2 = false;
    // Start is called before the first frame update
    /*void Start()
    {
        Button btn = GetComponent<Button>();
        //btn.onClick.AddListener(ChangeTrigger);
    }*/

    // Update is called once per frame
    public void ChangePtTrigger()
    {
        shouldRotate = true;
        animator_player.SetTrigger("isPt"); // Trigger 변경
        animator_ball.SetTrigger("isPt");
    }

    public void ChangeFfTrigger()
    {
        shouldRotate = true;
        animator_player.SetTrigger("isFf"); // Trigger 변경
        animator_ball.SetTrigger("isFf");
    }

    public void ChangeJpTrigger()
    {
        shouldRotate2 = true;
        animator_player.SetTrigger("isJp"); // Trigger 변경
        animator_ball.SetTrigger("isJp");
    }

    public void ChangeVdTrigger()
    {
        shouldRotate = false;
        animator_player.SetTrigger("isVd"); // Trigger 변경
        animator_ball.SetTrigger("isVd");
    }

    public void ChangeMtTrigger()
    {
        shouldRotate = false;
        animator_player.SetTrigger("isMt"); // Trigger 변경
        animator_ball.SetTrigger("isMt");
    }

    public void ChangeSpTrigger()
    {
        animator_player.SetTrigger("isSp"); // Trigger 변경
        animator_ball.SetTrigger("isSp");
    }


    private void Update()
    {
        if (shouldRotate)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (shouldRotate2)  //애니메이션의 이름
        {
            IsAnimationFinished("Jp_Right");
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            shouldRotate = true; // 다음 프레임부터 회전을 계속 적용
        }

    }

    private bool IsAnimationFinished(string animationName)
    {
        AnimatorStateInfo stateInfo = animator_player.GetCurrentAnimatorStateInfo(0);
        // 0은 base layer
        return stateInfo.IsName(animationName) && stateInfo.normalizedTime >= 1.0f;
    }
}
