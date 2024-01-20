using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCtrl : MonoBehaviour
{
    //updown speed
    public float scrollSpeedY;

    // Saving several background materials
    public Material[] backgrounds;  
    
    // time interval of changing the background
    public float changeInterval = 10.0f;  

    // refering the Renderer component attached on the game object
    private Renderer backgroundRenderer;

    // saving the index of current background
    private int currentBackgroundIndex = 0;

    // add next background index 
    //private int nextBackgroundIndex = 1; 

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();

        // initialize the current background to the first material
        backgroundRenderer.material = backgrounds[currentBackgroundIndex];

        StartCoroutine(ChangeBackground());
    }

    IEnumerator ChangeBackground()
    {
        while (true)
        {
            // ???? ???? ?????? ????
            int nextBackgroundIndex = (currentBackgroundIndex + 1) % backgrounds.Length;

            // ?????? ?????? ?????? ???? Material ????
            yield return new WaitForSeconds(changeInterval);

            // Material ????
            backgroundRenderer.material = backgrounds[nextBackgroundIndex];

            // ???? ???? ?????? ????????
            currentBackgroundIndex = nextBackgroundIndex;

            // ?????? ????
            Debug.Log("Background changed to: " + backgrounds[currentBackgroundIndex].name);
        }
    }

    /*IEnumerator ChangeBackground()
  {
      while (true)
      {
          // ???? ???? ?????? ????
          int nextBackgroundIndex = currentBackgroundIndex + 1;

          // ?????? ???? ???????? nextBackgroundIndex?? 0???? ????
          if (nextBackgroundIndex >= backgrounds.Length)
          {
              nextBackgroundIndex = 0;
          }
          backgroundRenderer.material.Lerp(backgrounds[currentBackgroundIndex], backgrounds[nextBackgroundIndex], changeInterval);

          yield return new WaitForSeconds(changeInterval);

          currentBackgroundIndex = nextBackgroundIndex;        
      }
  }  */

    // Update is called once per frame
    void Update()
    {

        backgroundRenderer.material.mainTextureOffset = new Vector2(0, Time.realtimeSinceStartup * scrollSpeedY);

        //Debug.Log(backgrounds[currentBackgroundIndex]);
        /*
        // keep track the time on each frame
        transitionTimer += Time.deltaTime;

        

        if(transitionTimer >= changeInterval)
        {
            transitionTimer = 0.0f;
            //currentBackgroundIndex = (currentBackgroundIndex + 1)   % backgrounds.Length;
            //nextBackgroundIndex = (nextBackgroundIndex + 1) % backgrounds.Length;
        }

        // calculate the time bewteen the current background and the next one
        float t = transitionTimer / changeInterval;

        // changing degree
        backgroundRenderer.material.Lerp(backgrounds[currentBackgroundIndex], backgrounds[nextBackgroundIndex], t);
    
        */
    }
}
