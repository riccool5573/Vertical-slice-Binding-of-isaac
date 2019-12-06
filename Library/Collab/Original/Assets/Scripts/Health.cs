using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    private bool isHit;
    private int dmg = 1;
    public GameObject death;
    public GameObject soul;

    Color color = new Color(5f, 0f, 0f);
    Color defaultColor;
    void Start()
    {
    
        isHit = false;
        defaultColor = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Instantiate(death, new Vector3(2, -0.5f, 0), Quaternion.identity);
            Instantiate(soul, new Vector3(0, 0.5f, 0), Quaternion.identity);
            Destroy(this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            isHit = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            health = 0;
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
