using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo2 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigo.magia == 1)
        {

            StartCoroutine(Atacar());

        }
    }

  
    
       
    

    IEnumerator Atacar()
    {
        //play your sound
        yield return new WaitForSeconds(4); //waits 3 seconds
        ContadorAmor.Amor -= 0.02f;
        
        enemigo.magia = 0;
        if (gameObject.tag == "person1")
        {
            Destroy(gameObject);

        }




    }
}
