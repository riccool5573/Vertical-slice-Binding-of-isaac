using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public void knockBack(int direction)
    {
        switch (direction)
        {
            case 1:
                transform.Translate(0, Time.deltaTime * -50, 0);
                break;
            case 2:
                transform.Translate(Time.deltaTime * -50, Time.deltaTime * -50, 0);
                break;
            case 3:
                transform.Translate(Time.deltaTime * -50, 0, 0);
                break;
            case 4:
                transform.Translate(Time.deltaTime * -50, Time.deltaTime * 50, 0);
                break;
            case 5:
                transform.Translate(0, Time.deltaTime * 50, 0);
                break;
            case 6:
                transform.Translate(Time.deltaTime * 50, Time.deltaTime * 50, 0);
                break;
            case 7:
                transform.Translate(Time.deltaTime * 50, 0, 0);
                break;
            case 8:
                transform.Translate(Time.deltaTime * 50, Time.deltaTime * -50, 0);
                break;

        }
    }
}
