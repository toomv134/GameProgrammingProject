using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EArcherUnitBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EBuildingManager.instance.A_building.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
