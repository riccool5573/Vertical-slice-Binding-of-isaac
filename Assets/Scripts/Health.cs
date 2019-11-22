using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    private bool isHit;
    private int dmg = 1;

    Color color = new Color(5f, 0f, 0f);
    Color defaultColor;
    void Start()
    {
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
            health = health - dmg; //Sets the health;
            isHit = false;
            gameObject.GetComponent<Renderer>().material.color = color; //Changes color to red when hit
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = defaultColor; //Changes color back to deafault
        }
    }
}
