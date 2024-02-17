using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Halland, Kangin, Mbappe, Ronaldo, Sonny, No
        //순서대로 0~5를 가짐
}
public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;  
}
