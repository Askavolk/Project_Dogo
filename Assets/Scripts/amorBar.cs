using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class amorBar : MonoBehaviour
{

    public Image Bar;

    public float maxhitpoint = 100;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthbar();
    }





    //Make the life bar become small if it takes damage
    private void UpdateHealthbar()
    {
        float ratio = ContadorAmor.Amor; /*maxhitpoint; */
        Bar.rectTransform.localScale = new Vector3(ratio, 1, 1);

        

    }
}