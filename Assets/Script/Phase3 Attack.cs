using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3Attack : MonoBehaviour
{

    public void attack()
    {
        Debug.Log("attack");
        PlayerManager.instance.Attack = true;
    }

    public void noattack()
    {
        Debug.Log("no attack");
        PlayerManager.instance.Attack = false;
    }
}
