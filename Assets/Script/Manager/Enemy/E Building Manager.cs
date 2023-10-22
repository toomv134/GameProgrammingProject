using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBuildingManager: MonoBehaviour //어떤 건물이 몇개 지어져있는지 관리
{
    public static EBuildingManager instance;

    //public GameObject buildingmanager;

    public List<EResourceBuilding> R_building;
    public List<EPaladinUnitBuilding> P_building;
    public List<ELancerUnitBuilding> L_building;
    public List<EArcherUnitBuilding> A_building;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Duplicated BuildingManager, ignoring this one", gameObject);
        }
    }

}
