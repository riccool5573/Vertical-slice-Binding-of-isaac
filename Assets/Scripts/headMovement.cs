using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
   

    // Update is called once per frame
    void Update()
    {
 
        anim.SetInteger("movement", 0);
        if (Input.GetKey(KeyCode.D))
        {
            
            anim.SetInteger("movement", 2);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
          
            anim.SetInteger("movement", 4);
           
        }
        if (Input.GetKey(KeyCode.S))
        {
          
            anim.SetInteger("movement", 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
          
            anim.SetInteger("movement", 1);
          

        }
    }
}
