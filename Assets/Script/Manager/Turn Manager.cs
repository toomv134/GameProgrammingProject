using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TurnManager: MonoBehaviour
{
    public static TurnManager instance;

    public float Day;
    public float Phase;

    [SerializeField] private GameObject firstphase;
    [SerializeField] private GameObject firstXbutton;
    [SerializeField] private GameObject secondphase;
    [SerializeField] private GameObject secondXbutton;
    [SerializeField] private GameObject thirdphase;
    [SerializeField] private GameObject thirdXbutton;
    [SerializeField] private GameObject thirdAttackbutton;

    private float Paladin;
    private float Lancer;
    private float Archer;
    private float MP;
    private float R_building;
    private float P_building;
    private float L_building;
    private float A_building;
    //private float Fortress_hp;
    //private float Castle_hp;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Duplicated Turn, ignoring this one", gameObject);
        }
    }
    private void Start()
    {
        Day = 0;
        TurnStart();
    }

    public void TurnStart()
    {
        Day++;
        Phase1();
    }
    public void TurnEnd()
    {
        //턴 끝나면 자원 보충
        //PResourceManager.instance.MP += 50 + PBuildingManager.instance.R_building.Count * 50;
        //EResourceManager.instance.MP += 50 + EBuildingManager.instance.R_building.Count * 50;
        //유닛 보충
        
    }
    public void Phase1() //전날이랑 비교
    {
        if (Day == 1) //첫날은 안보여줘도됨  
        {
            Debug.Log(Day);
            Phase2();
        }
        else
        {
            Time.timeScale = 1;
            Debug.Log("Phase1 start");
            Debug.Log(Day);
            Turn_phase1.instance.phase1 = true;
            thirdphase.SetActive(false);
            firstphase.SetActive(true);
            Time.timeScale=0;
            
        }
    }
    public void Phase2() // 건물 짓기
    {
        Time.timeScale = 1;
        firstphase.SetActive(false);
        secondphase.SetActive(true);
        Turn_phase1.instance.phase1 = false;
        
        Debug.Log("Phase2 start");
    }
    public void Phase3() // 공격여부 결정
    {
        Time.timeScale = 0;
        secondphase.SetActive(false);
        thirdphase.SetActive(true);
        
    }
}
