using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemySet : MonoBehaviour
{
    public float delay;
    public GameObject enemyFront;
    public GameObject enemyLeft;
    public GameObject enemyRight;
    public GameObject enemyLeftTackcle;
    public GameObject enemyRightTackcle;
    private GameObject[] enemySetFront = new GameObject[31];
    private GameObject[] enemySetLeft = new GameObject[31];
    private GameObject[] enemySetRight = new GameObject[31];
    private GameObject[] enemySetLeftTackle = new GameObject[31];
    private GameObject[] enemySetRightTackle = new GameObject[31];
    //사람 6개, 경로 3개, 
    private int[,] enemyActive = new int[,] {    {0, 0, 0},  { 0,  1,  0}, 
                                                 {0, 0, 0},  { 0,  0,  1},
                                                 {0, 0, 0},  { 1,  0,  1}, 
                                                 {0, 0, 0},  { 0,  1,  0},
                                                 {0, 0, 0},  { 1,  1,  1}, 
                                                 {0, 0, 0},  { 0,  1,  0}, 
                                                 {0, 0, 0},  { 0,  0,  1},
                                                 {0, 0, 0},  { 1,  0,  1}, 
                                                 {0, 0, 0},  { 0,  1,  0},
                                                 {0, 0, 0},  { 1,  1,  1} 
                                                 
    };
    // void Start()
    // {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         for (int j = 1; j <= 3; j++)
    //         {
    //             enemySet[i*3+j] = Instantiate(enemy, new Vector3(2f*(j-2), 0f, 15f), Quaternion.Euler(0,180,0));
    //             enemyset[i*3+j].SetActive(false);
    //             enemyset[i*3+j] = Instantiate(enemy, new Vector3(2f*(j-2), 0f, 15f), Quaternion.Euler(0,180,0));
    //             enemyset[i*3+j].SetActive(false);
    //             enemyset[i*3+j] = Instantiate(enemy, new Vector3(2f*(j-2), 0f, 15f), Quaternion.Euler(0,180,0));
    //             enemyset[i*3+j].SetActive(false);
    //         }
    //     }
    //     
    //     StartCoroutine(enemyInit(delay, 0));
    // }
    //
    // void Update()
    // {
    //     
    // }
    //
    // IEnumerator enemyInit(float delayTime, int caseNum)             
    // {
    //     // Debug.Log("Time = "+ Time.time);
    //     if (caseNum < 10)
    //     {
    //         if (enemyActive[caseNum, 0] != 0)
    //         {
    //             enemyset[enemyActive[caseNum, 0]].SetActive(true);
    //         }
    //         if (enemyActive[caseNum, 1] != 0)
    //         {
    //             enemyset[enemyActive[caseNum, 1]].SetActive(true);
    //         }
    //         if (enemyActive[caseNum, 2] != 0)
    //         {
    //             enemyset[enemyActive[caseNum, 2]].SetActive(true);
    //         }
    //     }
    //     yield return new WaitForSeconds(delayTime);
    //     StartCoroutine(enemyInit(delay, caseNum+1));
    // }
}
