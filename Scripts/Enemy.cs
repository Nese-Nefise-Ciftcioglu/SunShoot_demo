using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isLevelSucceed;
     private bool isCoroutineExecuting = false;
    public float maxhealth;
    public float currentHealth;
    private Rigidbody2D rb;
    public GameObject theCam;
    public GameObject sunEffect;

    [SerializeField]
    private GameObject sunBoomEffect;
    [SerializeField]
    private GameObject getShotEffect;

    public GameObject[] planets;

    
    public void TakeDamage(float damage)
    {   theCam.GetComponent<Animator>().Play("cameraShakeAnim1");
        //Instantiate(getShotEffect, transform.position,transform.rotation);
        gameObject.GetComponent<Animator>().Play("sunGetDam");
       
        currentHealth -= damage;
        if (currentHealth<= 0)
        {
            
            Instantiate(sunBoomEffect, transform.position,transform.rotation);
            theCam.GetComponent<Animator>().Play("cameraShakeAnim2");
            Destroy(gameObject);
            for(int i =0;i<planets.Length;i++){
                Destroy(planets[i]);
            }
            Destroy(sunEffect);
            isLevelSucceed = true;
            
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isLevelSucceed = false;
        currentHealth = maxhealth;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       StartCoroutine(ExecuteAfterTime(3f)); 
    }

 IEnumerator ExecuteAfterTime(float time)
 {
     if (isCoroutineExecuting)
         yield break;
 
     isCoroutineExecuting = true;
 
     yield return new WaitForSeconds(time); 
     
    if(currentHealth != maxhealth){
        currentHealth++;
    }
 
     isCoroutineExecuting = false;
 }
}
