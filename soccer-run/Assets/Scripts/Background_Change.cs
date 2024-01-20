using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Change : MonoBehaviour
{
    public GameObject backgroundPrefab; //��� ������
    public int numberOfBackgrounds = 10; //������ ����� ��
    public float backgroundWidth = 10f; //������ ����� �ʺ�


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
            // ��� �������� �ν��Ͻ��� �����ϰ� ��ġ�� ����
            GameObject background = Instantiate(backgroundPrefab, new Vector3(i * backgroundWidth, 0, 0), Quaternion.identity);
            background.transform.SetParent(transform); // ������ ����� ���� ������Ʈ�� �ڽ����� ���� (���� ����)
        }
    }
}
