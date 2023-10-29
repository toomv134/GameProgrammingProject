using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    
    public static BattleManager instance;
    public float cameranum = -1;
    private float cnt = 0;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TurnManager.instance.Onattack&&cnt==0)
        {
            cnt = 1;
            Debug.Log("BMstart");
            selectPlace();
            
        }
     
    }
    private void LateUpdate()
    {
        if (cameranum != -1)
        {
<<<<<<< HEAD
            
            EndFight();
=======
            //EndFight();
        }
    }

    private void EndFight()
    {
        switch (cameranum)
        {
            case 0:
                if ((PUnitManager.instance.P_units.Count + PUnitManager.instance.L_units.Count + PUnitManager.instance.A_units.Count) ==0|| 
                    (EUnitManager.instance.P_units.Count + EUnitManager.instance.L_units.Count + EUnitManager.instance.A_units.Count) == 0)
                {
                    ReturnArmy();
                    cameranum = -1;
                    PUnitManager.instance.units.Add(GameObject.Find("Player Castle Unit").GetComponent<PUnit>());
                    EUnitManager.instance.units.Add(GameObject.Find("Enemy Castle Unit").GetComponent<EUnit>());
                    if (PUnitManager.instance.fortress)
                    {
                        PUnitManager.instance.units.Add(GameObject.Find("Player Fortress Unit").GetComponent<PUnit>());
                    }
                    if (EUnitManager.instance.fortress)
                    {
                        EUnitManager.instance.units.Add(GameObject.Find("Enemy Fortress Unit").GetComponent<EUnit>());
                    }
                }
                break;
            case 1:
                if (!EUnitManager.instance.fortress|| (PUnitManager.instance.P_units.Count + PUnitManager.instance.L_units.Count + PUnitManager.instance.A_units.Count) == 0)
                {
                    ReturnArmy();
                    cameranum = -1;
                }
                break;
            case 2:
                if (!EUnitManager.instance.castle || (PUnitManager.instance.P_units.Count + PUnitManager.instance.L_units.Count + PUnitManager.instance.A_units.Count) == 0)
                {
                    ReturnArmy();
                    cameranum = -1;
                }
                break;
            case 3:
                if (!PUnitManager.instance.fortress || (EUnitManager.instance.P_units.Count + EUnitManager.instance.L_units.Count + EUnitManager.instance.A_units.Count) == 0)
                {
                    ReturnArmy();
                    cameranum = -1;
                }
                break;
            case 4:
                if (!PUnitManager.instance.castle || (EUnitManager.instance.P_units.Count + EUnitManager.instance.L_units.Count + EUnitManager.instance.A_units.Count) == 0)
                {
                    ReturnArmy();
                    cameranum = -1;
                }
                break;
            default:
                break;

>>>>>>> 2e014feaac0d4524339e8b0d4670ee19be5f16c4
        }
    }

    private void ReturnArmy()
    {
        EUnitManager.instance.Archer = EUnitManager.instance.A_units.Count;
        EUnitManager.instance.Lancer = EUnitManager.instance.L_units.Count;
        EUnitManager.instance.Paladin = EUnitManager.instance.P_units.Count;
        PUnitManager.instance.Archer = PUnitManager.instance.A_units.Count;
        PUnitManager.instance.Lancer = PUnitManager.instance.L_units.Count;
        PUnitManager.instance.Paladin = PUnitManager.instance.P_units.Count;
   
}
    private void makeArmyzero()
    {
        EUnitManager.instance.Archer = 0;
        EUnitManager.instance.Lancer = 0;
        EUnitManager.instance.Paladin = 0;
        PUnitManager.instance.Archer = 0;
        PUnitManager.instance.Lancer = 0;
        PUnitManager.instance.Paladin = 0;
    }
    private void makefieldArmyzero()
    { 
            for (int i = PUnitManager.instance.P_units.Count - 1; i >= 0; i--)
            {
                GameObject.Find("Player Paladin(Clone)").GetComponent<Life>().amount=0;
            }
        
    }
    
    
    
    private void selectPlace()
    {
        if (TurnManager.instance.Onattack && EnemyManager.instance.Attack) //attack both 평야
        {
            cameranum = 0;
            //카메라 옮기기
            //평야에 있는 스포너에 유닛 할당
            PUnitManager.instance.units.Remove(GameObject.Find("Player Castle Unit").GetComponent<PUnit>());
            PUnitManager.instance.units.Remove(GameObject.Find("Player Fortress Unit").GetComponent<PUnit>());
            EUnitManager.instance.units.Remove(GameObject.Find("Enemy Castle Unit").GetComponent<EUnit>());
            EUnitManager.instance.units.Remove(GameObject.Find("Enemy Fortress Unit").GetComponent<EUnit>());
            GameObject.Find("BattleFieldSpawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
            GameObject.Find("BattleFieldSpawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
            GameObject.Find("BattleFieldSpawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
            GameObject.Find("BattleFieldSpawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
            GameObject.Find("BattleFieldSpawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
            GameObject.Find("BattleFieldSpawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
        }
        else if (TurnManager.instance.Onattack) // player attack, enemy don't 
        {
            if (EUnitManager.instance.fortress)
            { //2차성루 안부서졌음
                cameranum = 1;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
                GameObject.Find("1st Enemy Site Spawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
            }
            else
            { //2차성루 부서짐
                //Debug.Log("2nd destroyed , lancer unit : " + PUnitManager.instance.Lancer);
                cameranum = 2;
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
                cameranum = 3;
                GameObject.Find("1st Player Site Spawner").GetComponent<EArcherSpawn>().num = EUnitManager.instance.Archer;
                GameObject.Find("1st Player Site Spawner").GetComponent<ELancerSpawn>().num = EUnitManager.instance.Lancer;
                GameObject.Find("1st Player Site Spawner").GetComponent<EPaladinSpawn>().num = EUnitManager.instance.Paladin;
                GameObject.Find("1st Player Site Spawner").GetComponent<PArcherSpawn>().num = PUnitManager.instance.Archer;
                GameObject.Find("1st Player Site Spawner").GetComponent<PLancerSpawn>().num = PUnitManager.instance.Lancer;
                GameObject.Find("1st Player Site Spawner").GetComponent<PPaladinSpawn>().num = PUnitManager.instance.Paladin;
            }
            else
            { //2차성루 부서짐
                cameranum = 4;
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
        makeArmyzero();
    }

    private void EndFight()
    {
        int player_unit = PUnitManager.instance.P_units.Count+ PUnitManager.instance.L_units.Count+ PUnitManager.instance.A_units.Count;
        int enemy_unit = EUnitManager.instance.P_units.Count + EUnitManager.instance.L_units.Count + EUnitManager.instance.A_units.Count;
        
        switch (cameranum)
        {

            case 0:
                if (player_unit == 0 || enemy_unit == 0)
                {
                    ReturnArmy();
                    makefieldArmyzero();
                    cameranum = -1;
                    TurnManager.instance.checkWinorLose();
                }
                break;
            case 1:
                if (!EUnitManager.instance.fortress || player_unit == 0)
                {
                    
                    ReturnArmy();
                    makefieldArmyzero();
                    cameranum = -1;
                    TurnManager.instance.checkWinorLose();
                }
                break;
            case 2:
                if (!EUnitManager.instance.castle || player_unit == 0)
                {
                    ReturnArmy();
                    makefieldArmyzero();
                    cameranum = -1;
                    TurnManager.instance.checkWinorLose();
                }
                break;
            case 3:
                if (!PUnitManager.instance.fortress || enemy_unit == 0)
                {
                    ReturnArmy();
                    makefieldArmyzero();
                    cameranum = -1;
                    TurnManager.instance.checkWinorLose();
                }
                break;
            case 4:
                if (!PUnitManager.instance.castle || enemy_unit == 0)
                {
                    ReturnArmy();
                    makefieldArmyzero();
                    cameranum = -1;
                    TurnManager.instance.checkWinorLose();
                }
                break;
            default:
                break;

        }
    }

}
