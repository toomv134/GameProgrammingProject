using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELancerUnitBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EBuildingManager.instance.L_building.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
