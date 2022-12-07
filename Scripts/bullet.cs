using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float damage;

    
 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        oneShotPlanet oneshotplanet = collision.GetComponent<oneShotPlanet>();
        twoShotPlanet twoshotplanet = collision.GetComponent<twoShotPlanet>();
        amooGiverPlanet ammoGiver = collision.GetComponent<amooGiverPlanet>();
        
        
        
        if (enemy != null){
            enemy.TakeDamage(damage);
        }
        else if (oneshotplanet != null){
            oneshotplanet.TakeDamage(damage);
        }
        else if (twoshotplanet != null){
            twoshotplanet.TakeDamage(damage);
        }
        else if (ammoGiver != null){
            ammoGiver.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

   
}
