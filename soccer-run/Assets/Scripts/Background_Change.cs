using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Change : MonoBehaviour
{
    public GameObject backgroundPrefab; 
    public int numberOfBackgrounds = 10; 
    public float backgroundDepth = 10f; 
    private GameObject player;
    private GameObject[] backgrounds;
    private float backmostBackgroundZ;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBackgrounds();
        ReSpawn reSpawn = FindObjectOfType<ReSpawn>();
        player = reSpawn.GetPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z > backmostBackgroundZ)
        {
            //Debug.Log(backmostBackgroundZ);
            MoveBack();
        }
    }

    void SpawnBackgrounds()
    {
        backgrounds = new GameObject[numberOfBackgrounds];

        for(int i = 0; i < numberOfBackgrounds; i++)
        {
           
            GameObject background = Instantiate(backgroundPrefab, new Vector3(0, 0, i * backgroundDepth), Quaternion.identity);
            
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

