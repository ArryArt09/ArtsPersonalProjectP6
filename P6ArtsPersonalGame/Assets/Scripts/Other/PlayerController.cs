using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement values
    public float speed = 5f;
    public float runSpeed = 2f;
    private float runVariable;
    public bool isTalking = false;
    private bool canMove = true;
    /*
    //Game bounds (get rid of later)
    public float xRange = 10;
    public float yRange = 10;
*/
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
        if (canMove)
        {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed * runVariable);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed * runVariable);
        }
        
        //Run System
        if (Input.GetKey(KeyCode.LeftShift))
        {
            runVariable = runSpeed;
        }
        else
        {
            runVariable = 1f;
        }
        /*
        //Game bounds (get rid of later)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        */
        if (isTalking)
        {
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }
}
