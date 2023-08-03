using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolve : MonoBehaviour
{
    public Transform Sun;
    public Transform Earth;
    public float Revolvespeed = 20f;
    void Update()
    {
        Earth.RotateAround(Sun.position,Vector3.up,80*Time.deltaTime);
    }
}
