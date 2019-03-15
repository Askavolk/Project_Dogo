using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
        
            var movement = Vector3.zero;

        if (Input.GetKey("a"))
            movement.x--;
        if (Input.GetKey("d"))
            movement.x++;



        transform.Translate(movement * speed * Time.deltaTime, Space.Self);
        transform.position = new Vector3(
          Mathf.Clamp(transform.position.x, -11.45f, 24.650f),
          Mathf.Clamp(transform.position.y, 7, 7),
          Mathf.Clamp(transform.position.z, -16.22f, -16.22f));
    }
}
