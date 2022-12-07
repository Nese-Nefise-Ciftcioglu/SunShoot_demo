using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void setActive()
    {
        gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void goMainMenu(){
       SceneManager.LoadScene("mainMenu");
    }
}
