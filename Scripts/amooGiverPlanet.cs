using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amooGiverPlanet : MonoBehaviour
{
    public float health;
    private Rigidbody2D rb;

    public GameObject bulletDisplayObject;

    [SerializeField]
    private GameObject bulletDestEffect;
    public Shooting shooting;
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health<= 0)
        {
            bulletDisplayObject.GetComponent<Animator>().Play("bulletLeftAddingAnim");
            Destroy(gameObject);
            //Instantiate(bulletDestEffect, transform.position,transform.rotation);
            shooting.currentAmmo+=3;
            

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
