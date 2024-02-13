using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectChr : MonoBehaviour
{
    public Character character;
    Animator anim;
    public SelectChr[] chars;

    void Start()
    {
        anim =GetComponent<Animator>();
        if (DataManager.instance.currentCharacter == character) OnSelect();
        else OnDeSelect();
    }

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentCharacter = character;
        OnSelect();
        Debug.Log(character);
        for (int i =0; i<chars.Length; i++)
        {
            if (chars[i] != this) chars[i].OnDeSelect();
        }
    }

    void OnDeSelect()
    {
        anim.SetBool("dance", false);
    }
    void OnSelect()
    {
        anim.SetBool("dance", true);
    }

    public void GoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
