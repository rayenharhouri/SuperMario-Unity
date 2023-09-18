using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatearound : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform cylender;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate around a chosen gameobject

        transform.RotateAround(cylender.position,transform.forward,1);
    }
}
