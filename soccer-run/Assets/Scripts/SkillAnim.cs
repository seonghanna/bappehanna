using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillAnim : MonoBehaviour
{
    public Animator animator_player;
    public Animator animator_ball;
    public GameObject boostItem;
    private bool isFastDribbling = false;
    private float fastDribbleTime = 0f;

    public void ChangePtTrigger()
    {
        animator_player.SetTrigger("isPt"); // Trigger 변경
        animator_ball.SetTrigger("isPt");
    }

    public void ChangeFfTrigger()
    {
        animator_player.SetTrigger("isFf"); // Trigger 변경
        animator_ball.SetTrigger("isFf");
    }

    public void ChangeJpTrigger()
    {
        animator_player.SetTrigger("isJp"); // Trigger 변경
        animator_ball.SetTrigger("isJp");
    }

    public void ChangeVdTrigger()
    {
        animator_player.SetTrigger("isVd"); // Trigger 변경
        animator_ball.SetTrigger("isVd");
    }

    public void ChangeMtTrigger()
    {
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
        if (isFastDribbling)
        {
            fastDribbleTime += Time.deltaTime;
            Debug.Log(fastDribbleTime);
            if (fastDribbleTime >= 3f)
            {
                animator_player.SetBool("IsFastDribble", false);
                fastDribbleTime = 0f;
                isFastDribbling = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "BOOST")
        {
            boostItem.SetActive(false);
            animator_player.SetBool("IsFastDribble", true);
            isFastDribbling = true;
        }
    }

    public void ResetRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
