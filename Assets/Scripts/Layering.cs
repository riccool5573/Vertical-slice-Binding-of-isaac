using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layering : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform Middle;
    private float difference;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        difference = this.transform.position.y - Middle.position.y;
        transform.position = new Vector3(transform.position.x, transform.position.y, difference);
        
    }
}
