using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSistem : MonoBehaviour
{
    public GameObject bom;
    bool onsistem = false;

    // Start is called before the first frame update
    void Start()
    {
        bom.SetActive(false);
        onsistem = false;
    }

    private void OnDestroy()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Red"))
        {

            if (onsistem == false)
            {
                bom.SetActive(true);
                //Destroy(this.gameObject);
                Invoke("OnDestroy", 3f);

                onsistem = true;
            }

        }
        if (other.gameObject.tag == ("Blue"))
        {
            if (onsistem == false)
            {
                bom.SetActive(false);
                Invoke("OnDestroy", 3f);

                onsistem = true;
            }
            
        }
        
        
    }
}
