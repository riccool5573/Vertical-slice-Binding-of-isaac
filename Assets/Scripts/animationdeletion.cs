using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationdeletion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(animdelete());
    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(0, Time.deltaTime * 3, 0);
    }
    IEnumerator animdelete()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
