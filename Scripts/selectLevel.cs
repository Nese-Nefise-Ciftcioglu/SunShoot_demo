using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectLevel : MonoBehaviour
{
    public int selectedLevelIndex;
    int levelsUnlocked;
    public Button[] buttons;

     public void goBack()
    {
        SceneManager.LoadScene("mainMenu");
    }

    void Start (){

        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked",1);
        for (int i=0;i<buttons.Length;i++)
        {
            buttons[i].interactable = false;
        }
           for (int i=0;i<levelsUnlocked;i++)
        {
            buttons[i].interactable = true;
        }

    }

    // Update is called once per frame
    public void selectCurrentLevel(int selectedLevelIndex)
    {
       SceneManager.LoadScene(selectedLevelIndex);
    }
}
