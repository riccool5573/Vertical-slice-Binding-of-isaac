using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour{

    public Transform firepointUp1;
    public Transform firepointDown1;
    public Transform firepointLeft1;
    public Transform firepointRight1;

    public Transform firepointUp2;
    public Transform firepointDown2;
    public Transform firepointLeft2;
    public Transform firepointRight2;

    public GameObject tear;

    private bool eyeSwap1;
    private bool eyeSwap2;
    private bool eyeSwap3;
    private bool eyeSwap4;

    //cooldown werkt niet :)
    public float coolDown = 1f;
    public float coolDownTimer;
    public Animator anim;
    public PlayerMovement player;
    private int movedir;
    public GameObject rangeHolder;

    void Update()
    {
        movedir = player.direction;

        if(coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if(coolDownTimer < 0)
        {
            coolDownTimer = 0;
           
        }

        
        //check for input and send that to Shoot()
        //up side of Isaac
        if (Input.GetKey(KeyCode.UpArrow) && eyeSwap1 && coolDownTimer == 0){
                Shoot(firepointUp1,"up");
                eyeSwap1 = false;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(1));
        }

            else if (Input.GetKey(KeyCode.UpArrow) && !eyeSwap1 && coolDownTimer == 0)
            {
                Shoot(firepointUp2, "up");
                eyeSwap1 = true;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(1));
        }

            //down side of Isaac
            else if (Input.GetKey(KeyCode.DownArrow) && eyeSwap2 && coolDownTimer == 0)
            {
                Shoot(firepointDown1,"down");
                eyeSwap2 = false;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(3));
        }

            else if (Input.GetKey(KeyCode.DownArrow) && !eyeSwap2 && coolDownTimer == 0)
            {
                Shoot(firepointDown2, "down");
                eyeSwap2 = true;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(3));
        }

            //left side of Isaac
            else if (Input.GetKey(KeyCode.LeftArrow) && eyeSwap3 && coolDownTimer == 0)
            {
                Shoot(firepointLeft1,"left");
                eyeSwap3 = false;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(4));
        }   

            else if (Input.GetKey(KeyCode.LeftArrow) && !eyeSwap3 && coolDownTimer == 0)
            {
                Shoot(firepointLeft2, "left");
                eyeSwap3 = true;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(4));
        }

            //right side of Isaac
            else if (Input.GetKey(KeyCode.RightArrow) && eyeSwap4 && coolDownTimer == 0)
            {
                Shoot(firepointRight1,"right");
                eyeSwap4 = false;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(2));

                Debug.Log("right");
        }

            else if (Input.GetKey(KeyCode.RightArrow) && !eyeSwap4 && coolDownTimer == 0)
            {
                Shoot(firepointRight2, "right");
                eyeSwap4 = true;
                coolDownTimer = coolDown;
                StartCoroutine(shootanim(2));
                
                
            Debug.Log("right");
        }


    }
     IEnumerator shootanim(int direction)
    {
        anim.SetInteger("shootingdirection", direction);
        anim.SetBool("shot", true);
        yield return new WaitForSecondsRealtime(0.2f);
        anim.SetBool("shot", false);
    }

    void Shoot(Transform direction, string Direction)
    {
        //shoot projectile in given direction
        GameObject Shot;
        GameObject holder;
        Shot = Instantiate(tear, direction.position, Quaternion.identity);
        Shot.GetComponent<BulletScript>().Direction = Direction;
        Shot.GetComponent<BulletScript>().drag = movedir;
        holder = Instantiate(rangeHolder, direction.position, Quaternion.identity);
        Shot.GetComponent<BulletScript>().rangeHolder = holder; //give rangeholder object to bullet
    }
 
}