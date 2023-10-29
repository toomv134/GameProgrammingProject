using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3Attack : MonoBehaviour
{

    public void attack()
    {
        if(PlayerManager.instance.attackday > 0) //can't attack 
        {
            Debug.Log("cannot attack");
            noattack();
        }
        else
        {
            Debug.Log("attack");
            PlayerManager.instance.Attack = true;
            PlayerManager.instance.attackday = 3;
        }
        
    }

    public void noattack()
    {
        Debug.Log("no attack");
        PlayerManager.instance.Attack = false;
        PlayerManager.instance.attackday -= 1;
    }
}
