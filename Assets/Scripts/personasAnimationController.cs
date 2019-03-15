using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personasAnimationController : MonoBehaviour
{
    Animator m_Animator;
    bool aplauso;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        aplauso = false;

    }

    // Update is called once per frame
    void Update()
    {
       
        m_Animator.SetBool("aplauso", aplauso);

        if (personMovement1.speed == 0)
        {
            aplauso = true;
            m_Animator.SetBool("aplauso", true);


        }
        else
        {
            aplauso = false;
            m_Animator.SetBool("aplauso", false);


        }


    }

}
