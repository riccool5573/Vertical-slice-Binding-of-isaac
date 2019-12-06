using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    public Image[] hearts;  
    public Sprite healthFull;
    public Sprite healthEmpty;

    public int currentHp;
    public int maxHp;


    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHp)
            {
                hearts[i].sprite = healthFull;
            }
            else
            {
                hearts[i].sprite = healthEmpty;
            }

            if (i < maxHp)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
