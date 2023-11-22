using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float slowSpeed = .5f;
    public float rotateSpeed = 1f;
    public bool rotateActivated = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rotateActivated = true;
        }
        if (Input.GetButtonUp("Jump"))
        {
            rotateActivated = false;
        }
        Move();
        Rotation();
    }

    void Move()
    {
        if (rotateActivated == true)
        {
            transform.Translate(Vector3.forward * slowSpeed * Time.deltaTime);
        }
        if (rotateActivated == false)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
    }
    
    void Rotation()
    {
        if (rotateActivated == true)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
