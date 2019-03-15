using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ArrowUp : MonoBehaviour
{
    Renderer rend;
    public static float Activado = 0;
    public static float minigameEnd = 0;
    public Image flecha;
    public Canvas CanvasObject;
    public static float minijuegoActivo = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (minijuegoActivo == 1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
            {
                ContadorAmor.Amor += 0.005f;
            }


        }

        if (minigameEnd == 6)
        {
            CanvasObject.GetComponent<Canvas>().enabled = false;
            minigameEnd = 0;
            minijuegoActivo = 0;
            spawner.spawnTime = Random.Range(16f, 26f);
            spawner2.spawnTime = Random.Range(16f, 26f);
            personMovement1.speed = 2;
            CharacterMovement.speed = 6;

        }

       if (CharacterMovement.speed == 0)
        {
            Activado += Time.deltaTime * 1;




        }



        if (Activado <=4.5f)
        {

           
            flecha.GetComponent<Image>().color = new Color32(255, 255, 255, 100);


        }


        if (Activado > 4.5f && Activado < 7.5f)
        {

            flecha.GetComponent<Image>().color = new Color32(0, 23, 225, 255);




        }

        if (Activado > 4.5f && Activado < 7.5f  && Input.GetKeyDown(KeyCode.UpArrow))
            {


            ContadorAmor.Amor += 0.005f;
            minigameEnd += 1;
            StartCoroutine(CoroutinaMagica());






        }
        if (Activado > 7.5f)
        {


            ContadorAmor.Amor -= 0.005f;
            Activado = 0;





        }
        if (Activado <= 4.5f && Input.GetKeyDown(KeyCode.UpArrow))
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

