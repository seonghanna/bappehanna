using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Change : MonoBehaviour
{
    public GameObject backgroundPrefab; //배경 프리팹
    public int numberOfBackgrounds = 10; //생성할 배경의 수
    public float backgroundDepth = 10f; //생성할 배경의 너비
    public Transform playerTransform; // 배경의 이동에 참고할 player의 위치값
    private GameObject[] backgrounds;
    private float backmostBackgroundZ;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBackgrounds();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > backmostBackgroundZ)
        {
            Debug.Log(backmostBackgroundZ);
            MoveBack();
        }
    }

    void SpawnBackgrounds()
    {
        backgrounds = new GameObject[numberOfBackgrounds];

        for(int i = 0; i < numberOfBackgrounds; i++)
        {
            // 배경 프리팹의 인스턴스를 생성하고 위치를 설정
            GameObject background = Instantiate(backgroundPrefab, new Vector3(0, 0, i * backgroundDepth), Quaternion.identity);
            //background.transform.SetParent(transform); // 생성된 배경을 현재 오브젝트의 자식으로 설정 (선택 사항)
            backgrounds[i] = background;
        }
        backmostBackgroundZ = backgrounds[2].transform.position.z;
        
    }

    void MoveBack()
    {
        GameObject backmostBackground = backgrounds[0];
        backmostBackground.transform.position = new Vector3(0, 0, backmostBackground.transform.position.z + numberOfBackgrounds * backgroundDepth);

        // Rearrange the array
        for (int i = 0; i < numberOfBackgrounds - 1; i++)
        {
            backgrounds[i] = backgrounds[i + 1];
        }
        backgrounds[numberOfBackgrounds - 1] = backmostBackground;
        backmostBackgroundZ = backgrounds[2].transform.position.z;

    }

}

