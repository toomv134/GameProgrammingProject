using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PResourceBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PBuildingManager.instance.R_building.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
