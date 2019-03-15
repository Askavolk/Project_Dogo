using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class leftArrow : MonoBehaviour
{
    Renderer rend;
    public static float Activado = 0;
    public static float minigameEnd = 0;
    public Image flecha;
    public Canvas CanvasObject;

    void Start()
    {

    }

    void Update()
    {


        if (minigameEnd == 6)
        {
            CanvasObject.GetComponent<Canvas>().enabled = false;
            spawner.spawnTime = Random.Range(16f, 26f);
            spawner2.spawnTime = Random.Range(16f, 26f);
            minigameEnd = 0;
            personMovement1.speed = 2;
            CharacterMovement.speed = 6;

        }




        if (CharacterMovement.speed == 0)
        {
            Activado += Time.deltaTime * 1;




        }



        if (Activado <= 2)
        {


            flecha.GetComponent<Image>().color = new Color32(255, 255, 255, 100);


        }


        if (Activado > 2 && Activado < 5)
        {

            flecha.GetComponent<Image>().color = new Color32(0, 23, 225, 255);




        }

        if (Activado > 2 && Activado < 5 && Input.GetKeyDown(KeyCode.LeftArrow))
        {


            ContadorAmor.Amor += 0.005f;
            StartCoroutine(CoroutinaMagica());





        }
        if (Activado > 5 )
        {


            ContadorAmor.Amor -= 0.005f;
            Activado = 0;





        }

        if (Activado <= 2 && Input.GetKeyDown(KeyCode.LeftArrow))
        {

            ContadorAmor.Amor -= 0.005f;
            flecha.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            Activado = 0;

        }

    }

    IEnumerator CoroutinaMagica()
    {
        //This is a coroutine


        yield return new WaitForSeconds(0.2f);

        //Wait one frame

        Activado = 0;
    }

}