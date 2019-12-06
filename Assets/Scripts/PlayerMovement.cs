using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    public Animator anim;
    public SpriteRenderer render;
    public AnimatorRecorderMode recorderMode;
    public int direction;

    public enum movingDirection
    {
        up,
        down,
        left,
        right
    }

    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    void FixedUpdate()
    {
    
        render.flipX = false; //make sure sprite isn't flipped when not needed
        anim.SetInteger("movement", 0); //reset sprite to idle when nothing is pressed
        direction = 0;
        //movement and animations
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0);
            anim.SetInteger("movement", 2);
            direction = 2;
        }
       if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * -speed, 0, 0);
            anim.SetInteger("movement", 4);
            render.flipX = true;
            direction = 4;
        }
      if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, Time.deltaTime * -speed, 0);
            anim.SetInteger("movement", 3);
            direction = 3;
        }
      if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * speed, 0);
            anim.SetInteger("movement", 1);
            render.flipX = true;
            direction = 1;
        }
    }
}
