using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Unit: MonoBehaviour
{
    public float speed; //unit speed
    public float distance; //unit attack range
    public float damage; // unit attack damage
    public float hp; //unit HP

    GameObject obj;

    private void Start()
    {
        //this.GetComponent<P2UnitManager>().units.Add(this);
        P2UnitManager.instance.units.Add(this);
        this.GetComponent<ForwardMovement>().speed = speed;
        //this.GetComponent<Toward>().speed = speed;
        //this.GetComponent<Life>().amount = hp;
        this.GetComponent<overlapspere>().radius = distance;
    }

    private void FixedUpdate()
    {
        if (this.GetComponent<Animator>().GetBool("EnemyinRange") && this.GetComponent<overlapspere>().enemy_inrange == false)
        {
            this.GetComponent<Animator>().SetBool("EnemyinRange", false);
        }
        else if (this.GetComponent<overlapspere>().enemy_inrange) //Enemy is in range
        {
            this.GetComponent<Animator>().SetBool("EnemyinRange", true);
            this.GetComponent<ForwardMovement>().speed = 0;
            //this.GetComponent<Toward>().target = this.GetComponent<overlapspere>().target.transform;
            //Debug.Log(this.GetComponent<overlapspere>().target.name);
            this.GetComponent<overlapspere>().target.GetComponent<Life>().amount -= damage;
        }
        
        else
        {
            this.GetComponent<ForwardMovement>().forward = P2UnitManager.instance.enemy_pos;
            //this.GetComponent<ForwardMovement>().speed = speed;
        }
    }
    private void Update()
    {
        //P2UnitManager.instance.pos.x += this.transform.position.x;
        //P2UnitManager.instance.pos.y += this.transform.position.y;
        //P2UnitManager.instance.pos.z += this.transform.position.z;


    }
    private void OnDestroy()
    {
        P2UnitManager.instance.units.Remove(this);
    }
}
