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
    public GameObject head;
    public Animator anim;
    public int frames;
    public bool hasinv;
    public bool isplayer;
    [HideInInspector]
    public float invframes;
   

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
        if (health <= 0)
        {
            if (anim == null)
            {
                Instantiate(death, new Vector3(gameObject.transform.position.x +2, -gameObject.transform.position.y +0.5f, gameObject.transform.position.z), Quaternion.identity);
                Instantiate(soul, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f, gameObject.transform.position.z), Quaternion.identity);
                Destroy(this.gameObject);
            }
            if (anim != null)
            {
                anim.SetBool("dead", true);
                StartCoroutine(deathanim());

            }
        }
        if(invframes > 0 && hasinv)
        {
            invframes -= Time.deltaTime;
        }
        if (isHit && invframes <= 0)
        {

            health = health - dmg; //Sets the health;
            isHit = false;
            gameObject.GetComponent<Renderer>().material.color = color; //Changes color to red when hit
            if (head != null)
            {
                head.GetComponent<Renderer>().material.color = color;
            }
            if (hasinv)
            {
                invframes = frames;
            }
        }
        else
        {
            isHit = false;
            gameObject.GetComponent<Renderer>().material.color = defaultColor; //Changes color back to deafault
            if (head != null)
            {
                head.GetComponent<Renderer>().material.color = defaultColor;
            }
        }
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (isplayer)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                hit(true);
            }
        }
    }
    IEnumerator deathanim()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        anim.SetBool("dead", false);
        Destroy(this.gameObject);
    }
    public void hit(bool hit)
    {
        isHit = hit;
    }
}
