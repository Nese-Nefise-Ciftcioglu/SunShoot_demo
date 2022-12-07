using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public GameObject coolDownIndicator;
     private bool isCoroutineExecuting = false;
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public int currentAmmo;
    public int maxAmmo = 10;
    public bool isDied;
    public bool isFiring;
    public TextMeshProUGUI ammoDisplay;

    

    // Start is called before the first frame update
    void Start()
    {        
        coolDownIndicator.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        isDied = false;
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
        ammoDisplay.text = currentAmmo.ToString();
            
       if(Input.GetMouseButtonDown(0) && currentAmmo!=0 && !isFiring){
            StartCoroutine(ExecuteAfterTime(1f));
            currentAmmo--;
            Instantiate(bulletPrefab,shootingPoint.position,transform.rotation); 
            //isFiring = false;
            
            
        }
        else if(currentAmmo==0 && isFiring == false){
            isDied=true;       
            
        }
        
        if (isDied == true){
            
            
        }
    
 }

  IEnumerator ExecuteAfterTime(float time)
 {
     if (isCoroutineExecuting)
         yield break;
    coolDownIndicator.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
     isCoroutineExecuting = true;
     isFiring = true;
     yield return new WaitForSeconds(time); 
     isFiring = false;
     coolDownIndicator.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
 
     isCoroutineExecuting = false;
 }
  

    
}
