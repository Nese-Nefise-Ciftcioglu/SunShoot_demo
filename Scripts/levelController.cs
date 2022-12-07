using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public LevelClearScreen levelClearScreen;
    public Enemy enemy;
    public Shooting shooting;

    // Start is called before the first frame update
    void Start()
    {      
    }
    // Update is called once per frame
    void Update()
    {
        if(enemy.isLevelSucceed == true ){
            levelClearScreen.setActive();
            shooting.isFiring = true;
        }
        else if (shooting.isDied==true){
             StartCoroutine(ExecuteAfterTime(0.8f));
             shooting.isFiring = true;
        }
        
    }


 IEnumerator ExecuteAfterTime(float time)
 {
 
     yield return new WaitForSeconds(time); 
     if(enemy.isLevelSucceed == false){
        gameOverScreen.setActive();
     }
 }

}

