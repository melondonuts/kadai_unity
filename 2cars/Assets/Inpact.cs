using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inpact : MonoBehaviour
{


    public GameObject bom;
    // Start is called before the first frame update
    void Start()
    {
        bom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Red"))
        {
            bom.SetActive(true);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == ("Blue"))
        {
            bom.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
