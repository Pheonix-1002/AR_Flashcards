using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed=0.004166f;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); 
    }
}
