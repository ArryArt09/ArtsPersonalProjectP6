using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveDock : MonoBehaviour
{

    public float speed;
  
    public float XposLimit;
    public float YposLimit = 25;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (0, (speed*Time.deltaTime)));

        if (transform.position.y > -YposLimit)
        {
            transform.position = new Vector3(transform.position.x, -YposLimit, transform.position.z);
        }
    }
}
