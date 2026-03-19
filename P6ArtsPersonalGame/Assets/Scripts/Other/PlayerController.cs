using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement values
    public float speed = 5f;
    public float runSpeed = 2f;
    private float runVariable;

    //Controls
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed * runVariable);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed * runVariable);

        //Run System
        if (Input.GetKey(KeyCode.LeftShift))
        {
            runVariable = runSpeed;
        }
        else
        {
            runVariable = 1f;
        }
    }
}
