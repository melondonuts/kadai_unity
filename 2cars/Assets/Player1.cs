using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{


    public GameObject player1;
    public GameObject player2;



    float Speed;
    private Rigidbody rb;
    private Rigidbody rb2;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb2 = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void FixedUpdate()
    {
        Rigidbody rb = player1.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, 0.0f, 0.1f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定

        Rigidbody rb2 = player2.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 now2 = rb2.position;            // 座標を取得
        now2 += new Vector3(0.0f, 0.0f, 0.1f);  // 前に少しずつ移動するように加算
        rb2.position = now2; // 値を設定

        if (Input.GetKey(KeyCode.A))
        {
            now= new Vector3(-2f, 0.0f, 0.0f);  // 前に少しずつ移動するように加算
        }
        if (Input.GetKey(KeyCode.D))
        {
            now= new Vector3(2f, 0.0f, 0.0f);  // 前に少しずつ移動するように加算
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            now2= new Vector3(-2f, 0.0f, 0.0f);  // 前に少しずつ移動するように加算
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            now2= new Vector3(2f, 0.0f, 0.0f);  // 前に少しずつ移動するように加算
        }
    }
}
