using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSistem : MonoBehaviour
{
    public GameObject bom;

    bool onsistem = false;

    public float Speed = 0.3f;

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        bom.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        onsistem = false;
    }

    private void OnDestroy()
    {
        Destroy(this.gameObject);
    }

    private void Update()
    {
        this.transform.Translate(0, Speed, 0);
    }

    //void DamageF()
    //{

    //    OcstacleSistem.DamageFlag = false;

    //}



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

                audioSource.PlayOneShot(sound1);
            }

        }
        if (other.gameObject.tag == ("Blue"))
        {
            if (onsistem == false)
            {
                bom.SetActive(false);
                Invoke("OnDestroy", 3f);

                OcstacleSistem.DamageFlag = true;

                onsistem = true;
            }
            
        }
        
        
    }
}
