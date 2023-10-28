using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    //public static Life instance;
    public float amount;
    //public UnityEvent onDeath;

    private void Update()
    {
        //Debug.Log(amount);
        if (amount <= 0)
        {
            Debug.Log("death");
            this.GetComponent<Animator>().SetTrigger("IsDeath");
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        
        //Debug.Log("death");
        yield return new WaitForSecondsRealtime(2.0f);
        Destroy(gameObject);
    }
}
