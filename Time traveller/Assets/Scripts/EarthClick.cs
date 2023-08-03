using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthClick : MonoBehaviour
{
    public Revolve Revolve; 
    public Rotate Rotate; 
    public GameObject Earthcam; 
    public GameObject Normalcam;
    public GameObject Sun;
    public GameObject Panel;
    float time=0;
    
    void Start(){
        Earthcam.SetActive(false);
        Panel.SetActive(false);
    }

    void OnMouseDown(){
        Normalcam.SetActive(false);
        Earthcam.SetActive(true);
        Rotate.enabled = false;
        Revolve.enabled = false;
        // time = 0;
    }

    void Update(){
        if(Earthcam.activeSelf){
        time+=Time.deltaTime;
        if(time>2f){
        Earthcam.SetActive(false);
        Sun.SetActive(false);
        Panel.SetActive(true);
        }
        }
    }
}
