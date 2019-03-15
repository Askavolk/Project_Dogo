using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovemnt : MonoBehaviour
{


    public Transform target;
    public static float speed = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime);




        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }


}