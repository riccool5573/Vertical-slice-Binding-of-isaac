using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;

    public string Direction;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        switch (Direction)
        {
            case "up":
                rb.AddForce(transform.up * speed);
                break;

            case "down":
                rb.AddForce(-transform.up * speed);
                break;

            case "left":
                rb.AddForce(-transform.right * speed);
                break;

            case "right":
                rb.AddForce(transform.right * speed);
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    { }
}
