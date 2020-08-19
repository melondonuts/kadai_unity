using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchRotate : MonoBehaviour
{
    public GameObject arch;

    float sensitivity = 0.5f; // いわゆるマウス感度

    float xSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // カーソル非表示
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // カーソルを画面内で動かせる
        //Cursor.lockState = CursorLockMode.Confined;

        Cursor.lockState = CursorLockMode.None;


        float mouse_move_x = Input.GetAxis("Mouse X") * sensitivity;
        float mouse_move_y = Input.GetAxis("Mouse Y") * sensitivity;

        float x = Input.GetAxis("Horizontal") * xSpeed;

        transform.Rotate(new Vector3(0, 0, -mouse_move_x));

        transform.Rotate(new Vector3(0, 0, -x));

    }

}
