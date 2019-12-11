using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [HideInInspector]
    public int direction;
    private int Speed = 250;
    private Rigidbody2D Rigidbody;
    public GameObject rangeHolder;
    public Animator anim;

    void Start()
    {

        Rigidbody = gameObject.GetComponent<Rigidbody2D>();
        switch (direction)
        {
            case 7:
                Rigidbody.AddForce(-transform.right * Speed);
                Rigidbody.AddForce(transform.up * Speed);
                // Debug.Log("up-left");
                break;
            case 6:
                Rigidbody.AddForce(-transform.right * Speed);
                // Debug.Log("left");
                break;
            case 5:
                Rigidbody.AddForce(-transform.right * Speed);
                Rigidbody.AddForce(-transform.up * Speed);
                // Debug.Log("left-down");
                break;
            case 4:
                Rigidbody.AddForce(-transform.up * Speed);
                //Debug.Log("down");
                break;
            case 3:
                Rigidbody.AddForce(transform.right * Speed);
                Rigidbody.AddForce(-transform.up * Speed);
                //Debug.Log("down-right");
                break;
            case 2:
                Rigidbody.AddForce(transform.right * Speed);
                // Debug.Log("right");
                break;
            case 1:
                Rigidbody.AddForce(transform.up * Speed);
                Rigidbody.AddForce(transform.right * Speed);
                //Debug.Log("right-up");
                break;
            case 0:
                Rigidbody.AddForce(transform.up * Speed);
                // Debug.Log("up");
                break;
            default:

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //check distance from where object was shot
        if (Vector2.Distance(this.transform.position, rangeHolder.transform.position) >= 10)
        {
            StartCoroutine(deathanim()); //destroy object and rangeholder object if object goes past range


        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemyknockback>().Owner.tag != "Enemy")
        {
            StartCoroutine(deathanim());
            Debug.Log("got here");
        }
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag != "projectile" && collision.gameObject.tag != "Playerprojectile")
        {
            StartCoroutine(deathanim());
            Debug.Log("got here");
        }
        

        
    }

        IEnumerator deathanim()
        {
            Rigidbody.velocity = Vector3.zero;
            anim.SetBool("death", true);
            yield return new WaitForSecondsRealtime(0.4f);
            Destroy(this.gameObject);
            Destroy(rangeHolder); //destroy object and rangeholder object if object goes past range
        }
    }

