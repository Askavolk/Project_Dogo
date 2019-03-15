using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorAmor : MonoBehaviour
{
    Text texto;
    public GameObject objshader1;
    public static float Amor = 0.0f;
    public Canvas CanvasObject;
    public static float deadCanvas = 0;


    // Start is called before the first frame update
    void Start()
    {
        Amor = 0.0f;
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        texto.text = Amor.ToString();

        if (Amor >= 0.0f)
        {

            objshader1.GetComponent<Renderer>().sharedMaterial.SetFloat("_Blend", Amor); 



        }
        if (Amor <= 0)
        {
            Amor = 0;


        }
        if (deadCanvas >= 1)
        {
            CanvasObject.GetComponent<Canvas>().enabled = true;
            personMovement1.speed = 0;
            StartCoroutine(GameLost());

        }
        if (Amor == 1)
        {

            Application.Quit();
        }

    }
    IEnumerator GameLost()
    {
        //play your sound
        yield return new WaitForSeconds(5); //waits 3 seconds
        Application.Quit();
    }
}
