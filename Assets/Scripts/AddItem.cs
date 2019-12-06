using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Key")
        {
            gameObject.GetComponent<UIDisplay>().key2++;
        }

        else if (col.gameObject.tag == "Coin")
        {
            gameObject.GetComponent<UIDisplay>().coin2++;
        }

        else if (col.gameObject.tag == "Bomb")
        {
            gameObject.GetComponent<UIDisplay>().bomb2++;
        }
    }
}
