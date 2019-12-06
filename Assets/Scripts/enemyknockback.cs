using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyknockback : MonoBehaviour
{
    public GameObject Enemyprojectile;
    public GameObject Owner;
    public int hitdir;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == Enemyprojectile.tag && Owner.GetComponent<Health>().invframes <= 0)
        {
            
            switch (this.gameObject.name)
            {
                case "Up":
                    hitdir = 1;
                    sentdir();
                    
                    break;
                case "Upright":
                    hitdir = 2;
                    sentdir();
                    break;
                case "Right":
                    hitdir = 3;
                    sentdir();
                    break;
                case "Rightdown":
                    hitdir = 4;
                    sentdir();
                    break;
                case "Down":
                    hitdir = 5;
                    sentdir();
                    break;
                case "Downleft":
                    hitdir = 6;
                    sentdir();
                    break;
                case "Left":
                    hitdir = 7;
                    sentdir();
                    break;
                case "Leftup":
                    hitdir = 8;
                    sentdir();
                    break;
            }
        }
    }
    void sentdir()
    {
        Owner.GetComponent<Knockback>().knockBack(hitdir);
        Owner.GetComponent<Health>().hit(true);
        

    }
}
