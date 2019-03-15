using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personMovement1 : MonoBehaviour
{

   
    public Transform target;
    public static float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime);

        StartCoroutine(Die());


        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    IEnumerator Die()
    {
        //play your sound
        yield return new WaitForSeconds(100); //waits 3 seconds
        Destroy(gameObject); //this will work after 3 seconds.
    }
}

