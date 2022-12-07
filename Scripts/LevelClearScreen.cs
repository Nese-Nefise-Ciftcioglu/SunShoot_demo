using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelClearScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void setActive()
    {
        gameObject.SetActive(true);
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel >= PlayerPrefs.GetInt("levelsUnlocked")){
                PlayerPrefs.SetInt("levelsUnlocked",currentLevel+1);
        }

        
    }
    public void goNextLevel(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
       public void goMainMenu(){
       SceneManager.LoadScene("mainMenu");
    }


   
}
