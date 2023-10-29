using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    public bool phase3;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("배틀 매니저가 두개이상!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        phase3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (phase3)
        {
            selectPlace();
            phase3 = false;
        }
    }

    void selectPlace()
    {
        if (TurnManager.instance.Onattack && EnemyManager.instance.Attack) //attack both 평야
        {
            //카메라 옮기기
            //평야에 있는 스포너에 유닛 할당
            GameObject.Find("BattelFieldSpawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
            GameObject.Find("BattelFieldSpawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
            GameObject.Find("BattelFieldSpawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
            GameObject.Find("BattelFieldSpawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
            GameObject.Find("BattelFieldSpawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
            GameObject.Find("BattelFieldSpawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
        }
        else if (TurnManager.instance.Onattack) // player attack, enemy don't 
        {
            if (EUnitManager.instance.fortress)
            { //2차성루 안부서졌음
                GameObject.Find("1st Enemy Site Spawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
            }
            else
            { //2차성루 부서짐
                GameObject.Find("2nd Enemy Site Spawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
                GameObject.Find("2nd Enemy Site Spawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
                GameObject.Find("2nd Enemy Site Spawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
                GameObject.Find("2nd Enemy Site Spawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
                GameObject.Find("2nd Enemy Site Spawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
                GameObject.Find("2nd Enemy Site Spawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
            }
        }
        else if (EnemyManager.instance.Attack) //enemy attack, player don't
        {
            if (PUnitManager.instance.fortress)
            { //2차성루 안부서졌음
                GameObject.Find("1st Player Site Spawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
                GameObject.Find("1st Player Site Spawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
                GameObject.Find("1st Player Site Spawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
                GameObject.Find("1st Player Site Spawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
                GameObject.Find("1st Player Site Spawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
                GameObject.Find("1st Player Site Spawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
            }
            else
            { //2차성루 부서짐
                GameObject.Find("2nd Player Site Spawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
                GameObject.Find("2nd Player Site Spawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
                GameObject.Find("2nd Player Site Spawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
                GameObject.Find("2nd Player Site Spawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
                GameObject.Find("2nd Player Site Spawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
                GameObject.Find("2nd Player Site Spawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
            }
        }
        else //don't attack both
        {

        }
    }
}
