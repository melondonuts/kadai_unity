using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fab : MonoBehaviour
{
    public GameObject Shot;

    public float Speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot.transform.Translate(0, 0, -Speed);
    }
}

