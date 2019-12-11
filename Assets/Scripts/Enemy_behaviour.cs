using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behaviour : MonoBehaviour
{
    [HideInInspector]
    int direction; //1 = up 2 = up-right etc

    private Rigidbody2D Rigidbody;
    private int Speed = 60;
    private float timer;
    private float Bullet;
    public GameObject projectile;
    public GameObject rangeHolder;
    public Animator anim;
    public SpriteRenderer render;
    private int spawntimer = 0;
    

    void Start()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody2D>();
        timer = Random.Range(1, 3);
        random_direction();    // give random timers to direction change and shooting
        Bullet = Random.Range(1, 8);
        anim.SetBool("start", true);
    }

    void random_direction()
    {
        render.flipX = false; //make sure animation is played the right way around
        direction = Random.Range(0, 8); //reset timer
        Rigidbody.velocity = Vector3.zero; //stop moving
      
        switch (direction) // add movement based on rng
        {
            case 7:
                Rigidbody.AddForce(-transform.right * Speed);
                Rigidbody.AddForce(transform.up * Speed);
                // Debug.Log("up-left");
                anim.SetInteger("movement", 1);
                render.flipX = true;
                break;
            case 6:
                Rigidbody.AddForce(-transform.right * Speed);
                // Debug.Log("left");
                anim.SetInteger("movement", 4);
                render.flipX = true;
                break;
            case 5:
                Rigidbody.AddForce(-transform.right * Speed);
                Rigidbody.AddForce(-transform.up * Speed);
                // Debug.Log("left-down");
                anim.SetInteger("movement", 3);
                break;
            case 4:
                Rigidbody.AddForce(-transform.up * Speed);
                //Debug.Log("down");
                anim.SetInteger("movement", 3);
                break;
            case 3:
                Rigidbody.AddForce(transform.right * Speed);
                Rigidbody.AddForce(-transform.up * Speed);
                //Debug.Log("down-right");
                anim.SetInteger("movement", 3);
                break;
            case 2:
                Rigidbody.AddForce(transform.right * Speed);
                // Debug.Log("right");
                anim.SetInteger("movement", 2);
                break;
            case 1:
                Rigidbody.AddForce(transform.up * Speed);
                Rigidbody.AddForce(transform.right * Speed);
                //Debug.Log("right-up");
                anim.SetInteger("movement", 1);
                render.flipX = true;
                break;
            case 0:
                Rigidbody.AddForce(transform.up * Speed);
                // Debug.Log("up");
                anim.SetInteger("movement", 1);
                render.flipX = true;
                break;
            default:

                break;
        }
    }

    void Update()
    {
        if(spawntimer < 6)
        {
            spawntimer++;
        }
        if(spawntimer == 6)
        {
            anim.SetBool("start", false);
        }
        timer -= Time.deltaTime;
        Bullet -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = Random.Range(4, 8);
            random_direction();
        }
        if(Bullet <= 0)
        {
            Bullet = Random.Range(1, 8);
            StartCoroutine(Shoot());
            
        }
    }
    IEnumerator Shoot()
    {
        GameObject shot;
        GameObject holder;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        shot = Instantiate(projectile, this.gameObject.transform.position , Quaternion.identity) ;
        shot.GetComponent<bullet>().direction = direction; //give movement direction to bullet
        holder = Instantiate(rangeHolder, this.gameObject.transform.position, Quaternion.identity);
        shot.GetComponent<bullet>().rangeHolder = holder; //give rangeholder object to bullet
        yield return new WaitForSecondsRealtime(0.4f);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
 
}
