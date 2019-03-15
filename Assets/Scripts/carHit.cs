using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class carHit : MonoBehaviour
{

    public GameObject perro;


    
    public static float perroChafado = 0;
  
    private bool triggerEntered = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        StartCoroutine(Die());


    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Tomas come porongas");
        if (col.gameObject.tag == "Player")
        {
            
            Debug.Log("Tomas Chupa Tremendas Poyas");

            Destroy(GameObject.FindWithTag("Player"));
            StartCoroutine(DogDead());





            CharacterMovement.speed = 0;
        }


    }
    


    //And function itself
    IEnumerator Die()
    {
        //play your sound
        yield return new WaitForSeconds(20); //waits 3 seconds
        Destroy(gameObject); //this will work after 3 seconds.
    }
    IEnumerator DogDead()
    {
        //play your sound
        yield return new WaitForSeconds(5); //waits 3 seconds
        ContadorAmor.deadCanvas += 1;
    }



}
