using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour{

    public Transform Firepoint_voor;
    public Transform Firepoint_achter;
    public Transform Firepoint_links;
    public Transform Firepoint_rechts;

    public GameObject tier;
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        //check for input and send that to Shoot()
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Shoot(Firepoint_voor,"up");
 
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Shoot(Firepoint_achter,"down");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Shoot(Firepoint_links,"left");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Shoot(Firepoint_rechts,"right");
        }

    }

    void Shoot(Transform direction, string Direction)
    {
        //shoot projectile in given direction
        GameObject Shot;

        Shot = Instantiate(tier, direction.position, Quaternion.identity);
        Shot.GetComponent<BulletScript>().Direction = Direction;
    }
 
}