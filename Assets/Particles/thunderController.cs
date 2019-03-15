using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thunderController : MonoBehaviour
{
    public float apagarHumo = 0;
    public float tiempo = 1;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigo.combate == true)
        {
            GetComponent<ParticleSystem>().Play();
            ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
            em.enabled = true;

            apagarHumo += 1;
            StartCoroutine(Apagar());
        }




    }
    IEnumerator Apagar()
    {
        //play your sound
        yield return new WaitForSeconds(3); //waits 3 seconds
        GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = false;
    }
}
