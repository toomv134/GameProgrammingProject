using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Turn_phase1 : MonoBehaviour //전날이랑 비교
{
    public static Turn_phase1 instance;
    public float Day;
    public bool phase1;
    private TMP_Text state;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Duplicated Turn_phase1, ignoring this one");
        }
    }

    private void Start()
    {
        state = GameObject.Find("State").GetComponent<TMP_Text>();
        phase1 = false;
        Debug.Log("Phase1 start");
        Day = TurnManager.instance.Day;
        
    }
    private void Update()
    {
        setStateText();

    }
    void setStateText()
    {
        if (phase1)
        {
            state.text = "Paladin : " + PUnitManager.instance.Paladin.ToString() +
            "\nLancer : " + PUnitManager.instance.Lancer.ToString() +
            "\nArcher : " + PUnitManager.instance.Archer.ToString() +
            "\nMP : " + PResourceManager.instance.MP.ToString() +
            "\nR_B : " + PBuildingManager.instance.R_building.Count.ToString() +
            "\nP_B : " + PBuildingManager.instance.P_building.Count.ToString() +
            "\nL_B : " + PBuildingManager.instance.L_building.Count.ToString() +
            "\nA_B : " + PBuildingManager.instance.A_building.Count.ToString();
        }
        else
        {
            state.text = "";
        }
    }
}
