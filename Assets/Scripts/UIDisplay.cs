using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{

    public Text coinText;
    private int coin1 = 0;
    public int coin2 = 1;

    public Text bombText;
    private int bomb1 = 0;
    public int bomb2 = 1;

    public Text keyText;
    private int key1 = 0;
    public int key2 = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bomb2++;
            coin2++;
            key2++;
        }

        //UI for the coins
        if (coin2 > 9)
        {
            coin1++;
            coin2 = 0;
        }

        else if (coin2 < 0)
        {
            coin1--;
            coin2 = 9;
        }

        else if(coin1 < 0 && coin2 < 0)
        {
            coin1 = 0;
            coin2 = 0;
        }

        //UI for the bombs
        if (bomb2 > 9)
        {
            bomb1++;
            bomb2 = 0;
        }

        else if (bomb2 < 0)
        {
            bomb1--;
            bomb2 = 9;
        }

        else if (bomb1 < 0 && bomb2 < 0)
        {
            bomb1 = 0;
            bomb2 = 0;
        }

        //UI for the keys
        if (key2 > 9)
        {
            key1++;
            key2 = 0;
        }

        else if (key2 < 0)
        {
            key1--;
            key2 = 9;
        }

        else if (key1 < 0 && key2 < 0)
        {
            key1 = 0;
            key2 = 0;
        }

        //this will be showing on screen
        coinText.text = coin1 + "" + coin2;
        bombText.text = bomb1 + "" + bomb2;
        keyText.text = key1 + "" + key2;
    }
}
