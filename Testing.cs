using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing
{
    private Grids grids;

    private void Start() {
         grids = new Grids(4,2,1f, new Vector3(0,-1));
        
    }

    private void Update(){
        if (Input.GetMouseButtonDown(0)){
           grids.SetValue(UtilsClass.GetMouseWorldPosition(),56 );
        }
        if (Input.GetMouseButtonDown(1)){
            Debug.Log(grids.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
    
}
