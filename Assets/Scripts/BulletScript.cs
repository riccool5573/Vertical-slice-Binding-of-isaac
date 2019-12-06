using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;

    public string Direction;

    public Rigidbody2D rb;

    public int drag;

    public GameObject rangeHolder;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        switch (drag)
        {
            case 1: rb.AddForce(transform.up * 100);
                break;
            case 2:
                rb.AddForce(transform.right *100);
                Debug.Log("right");
                break;
            case 3: rb.AddForce(-transform.up * 100);
                break;
            case 4:
                rb.AddForce(-transform.right * 100);
                Debug.Log("left");
                break;

        }
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
    {
        if (Vector2.Distance(this.transform.position, rangeHolder.transform.position) >= 10)
        {

            StartCoroutine(deathanim());


        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(deathanim());
    }
    public IEnumerator deathanim()
    {
        rb.velocity = Vector3.zero;
        anim.SetBool("dead", true);
        yield return new WaitForSecondsRealtime(0.4f);
        Destroy(this.gameObject);
        Destroy(rangeHolder); //destroy object and rangeholder object if object goes past range
    }
}
