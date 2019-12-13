using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePS : MonoBehaviour
{

    // Use this for initialization
    public ParticleSystem PS;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)){
            Instantiate(PS);
        }
    }
}
