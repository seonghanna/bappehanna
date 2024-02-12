using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl2 : MonoBehaviour
{
    private GameObject gameOverPanel;

    private void Start()
    {
        // 시간을 정상으로 복구
        Time.timeScale = 1f;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ENEMY")) // Enemy 태그를 가진 오브젝트와 충돌했는지 확인
        {
            Gameover();
            // 게임 오버 패널 활성화
            gameOverPanel.SetActive(true);
        }
    }


    void Gameover()
    {
        gameOverPanel = GameObject.FindWithTag("GAMEOVERPANEL");
        // 게임 정지
        Time.timeScale = 0f;
    }

    public void ResetRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
