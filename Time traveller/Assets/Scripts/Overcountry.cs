using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overcountry : MonoBehaviour
{
    public bool check;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     if (Physics.Raycast(ray, out hit, 0.402f)){
        check = true;
    }
    else{
        check = false;
    }
    }
}
