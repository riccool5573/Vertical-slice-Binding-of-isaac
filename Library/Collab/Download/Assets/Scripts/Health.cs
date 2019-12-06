using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    private bool isHit;
    private int dmg = 1;

    private Renderer rending;
    

    Color color = new Color(5f, 0f, 0f);
    Color defaultColor;
    void Start()
    {
        rending = GetComponent<Renderer>();
        health = 6;
        isHit = false;
        defaultColor = gameObject.GetComponent<Renderer>().material.color;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            isHit = true;
        }

        if (isHit)
        {
            TakeDamage();
        }
        else
        {
           rending.material.color = defaultColor; //Changes color back to deafault
        }
    }

    void TakeDamage()
    {
        health = health - dmg; //Sets the health;
        isHit = false;
        rending.material.color = color; //Changes color to red when hit
    }
}
