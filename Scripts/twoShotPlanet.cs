using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoShotPlanet : MonoBehaviour
{
    public float health;
    private Rigidbody2D rb;
    private float tempHealth;
    [SerializeField]
    private GameObject bulletDestEffect;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health==tempHealth){
                gameObject.transform.localScale = new Vector3(0.5085f, 0.490088f, 0f);
                gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (health<= 0)
        {
            Destroy(gameObject);
            //Instantiate(bulletDestEffect, transform.position,transform.rotation);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        tempHealth=health/2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
