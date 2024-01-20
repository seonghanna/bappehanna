using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Change : MonoBehaviour
{
    public GameObject backgroundPrefab; //배경 프리팹
    public int numberOfBackgrounds = 10; //생성할 배경의 수
    public float backgroundWidth = 10f; //생성할 배경의 너비


    // Start is called before the first frame update
    void Start()
    {
        SpawnBackgrounds();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBackgrounds()
    {
        for(int i = 0; i < numberOfBackgrounds; i++)
        {
            // 배경 프리팹의 인스턴스를 생성하고 위치를 설정
            GameObject background = Instantiate(backgroundPrefab, new Vector3(i * backgroundWidth, 0, 0), Quaternion.identity);
            background.transform.SetParent(transform); // 생성된 배경을 현재 오브젝트의 자식으로 설정 (선택 사항)
        }
    }
}
