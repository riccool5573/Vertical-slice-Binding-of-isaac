using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    public Image[] hearts;  
    public Sprite healthFull;
    public Sprite healthEmpty;
    private int health;

    public int currentHp;
    public int maxHp;

    void Start()
    {
        health = currentHp;
        Debug.Log(health);
    }

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
            if (Input.GetKey(KeyCode.Z))
            {

                i--;
                //hearts[i].fillAmount = currentHp / maxHp;
            }
        }
    }
}
