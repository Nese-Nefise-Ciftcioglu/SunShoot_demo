using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class mainMenuScreen : MonoBehaviour
{
     public TextMeshProUGUI currentLevelDisplay;
     int currentLevel;
 public void Start()
    {    currentLevel=PlayerPrefs.GetInt("levelsUnlocked");
         
         if(currentLevel==0){
                 currentLevelDisplay.text = "1";
         }
         else{
            currentLevelDisplay.text = PlayerPrefs.GetInt("levelsUnlocked").ToString();
         }
        
    }

   
    public void selectLevel()
    {
        SceneManager.LoadScene("selectlevel");
    }


   public void continueButton()
    {
        
         if(currentLevel==0){
             SceneManager.LoadScene(1);
                 
         }
         else{
            SceneManager.LoadScene(currentLevel);
         }

    }
 
    
}
