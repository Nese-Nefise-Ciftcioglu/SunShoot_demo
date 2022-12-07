using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneShotPlanet : MonoBehaviour
{
    public float health;
    private Rigidbody2D rb;
   

    [SerializeField]
    private GameObject bulletDestEffect;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health<= 0)
        {
            Destroy(gameObject);
            //Instantiate(bulletDestEffect, transform.position,transform.rotation);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
