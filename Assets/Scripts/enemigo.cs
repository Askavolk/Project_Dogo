using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public GameObject personaje;
    public GameObject malvado;
    public GameObject malvado2;
    public static int speed = 10;
    public static bool combate = false;
    public static float magia = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (combate == true)
        {
            CharacterMovement.speed = 0;
            

            float step = speed * Time.deltaTime;

            magia += 1;
            StartCoroutine(Atacar());
            MeshRenderer m = malvado.GetComponent<MeshRenderer>();
            m.enabled = false;


        }

        if (CharacterMovement.speed == 0 && combate == true)
        {
            StartCoroutine(Atacar());


        }
        
        



    }
    IEnumerator Atacar()
    {
        //play your sound
        yield return new WaitForSeconds(3); //waits 3 seconds
        ContadorAmor.Amor -= 0.02f;
        CharacterMovement.speed = 6;
        combate = false;
        Destroy(malvado);
        DestroyImmediate(malvado2, true) ;

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tomas come papayas");
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("Esto funciona loco");

            combate = true;
           
            GameObject m1 = Instantiate(malvado2, malvado.transform.position, transform.rotation);

            StartCoroutine(Atacar());

            m1.transform.position += new Vector3(3, 0, 0);
           
            CharacterMovement.speed = 0;

           // Destroy(malvado);

            


        }


    }
    
}
