using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PArcherUnitBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PBuildingManager.instance.A_building.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
