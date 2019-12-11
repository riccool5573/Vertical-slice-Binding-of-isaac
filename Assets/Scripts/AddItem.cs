using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    private UIDisplay UID;

    private void Start()
    {
        UID = GameObject.Find("coinText").GetComponent<UIDisplay>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Key")
        {
            UID.key2++;
        }

        else if (col.gameObject.tag == "Coin")
        {
            UID.coin2++;
        }

        else if (col.gameObject.tag == "Bomb")
        {
            UID.bomb2++;
        }
    }
}
