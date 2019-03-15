using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigameDicifulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ContadorAmor.Amor == 0.25)
        {
            if (CharacterMovement.speed == 0)
            {
                ArrowUp.Activado += Time.deltaTime * 4f;




            }
            



        }
        if (ContadorAmor.Amor == 0.50)
        {
            if (CharacterMovement.speed == 0)
            {
                ArrowUp.Activado += Time.deltaTime * 5f;




            }




        }
        if (ContadorAmor.Amor == 0.75)
        {
            if (CharacterMovement.speed == 0)
            {
                ArrowUp.Activado += Time.deltaTime * 6f;




            }




        }
    }
}
