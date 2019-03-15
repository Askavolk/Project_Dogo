using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// The GameObject is made to bounce using the space key.
// Also the GameOject can be moved forward/backward and left/right.
// Add a Quad to the scene so this GameObject can collider with a floor.

public class CharacterMovement : MonoBehaviour
{
    public static float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public GameObject person1;
    public Canvas CanvasObject;
    public GameObject coche;
    public GameObject perro;
    public GameObject perro2;
    public float rotSpeed = 90;

    Animator m_Animator;
    bool andar;
    bool saltar;
    bool bailar;
    bool derecha;



    private  bool triggerEntered = false;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private Collider Collider;

    void Start()
    {
        m_Animator = perro.gameObject.GetComponent<Animator>();
        andar = false;
        saltar = false;
        bailar = false;
        derecha = false;


        controller = GetComponent<CharacterController>();
        Collider = gameObject.GetComponent<Collider>();

        // let the gameObject fall down
        gameObject.transform.position = new Vector3(0, 5, 0);
    }

    void Update()
    {
        m_Animator.SetBool("andar", andar);
        m_Animator.SetBool("saltar", saltar);
        m_Animator.SetBool("bailar", bailar);
        m_Animator.SetBool("derecha", derecha);

        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            andar = false;

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetAxis("Horizontal") > 0)
            {
                
                perro.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }

            else if (Input.GetAxis("Horizontal") < 0)
            {
                

                perro.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
            
            if(ArrowUp.Activado > 4.5f && ArrowUp.Activado < 7.5f && Input.GetKeyDown(KeyCode.UpArrow))
                {
                derecha = true;
                    m_Animator.SetBool("derecha", true);


            }
            else
            {
                derecha = false;
                m_Animator.SetBool("derecha", false);

            }

            if (rightArrow.Activado > 4 && rightArrow.Activado < 8 && Input.GetKeyDown(KeyCode.RightArrow))
            {
                bailar = true;
                m_Animator.SetBool("bailar", true);
            }
            else
            {
                derecha = false;
                m_Animator.SetBool("bailar", false);

            }









            if (Input.GetAxis("Vertical") > 0)
            {
                perro.transform.localRotation = Quaternion.Euler(new Vector3(0, -85, 0));
                
            }
                
            else if (Input.GetAxis("Vertical") < 0)
            {
                
                perro.transform.localRotation = Quaternion.Euler(new Vector3(0, 92, 0));
            }
             

            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
            /*
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }*/
            if (Input.GetButton("Jump") /*&& carHit.perroChafado == 1 */)
            {
                saltar = true;
                moveDirection.y = jumpSpeed;
                
                carHit.perroChafado = 0;
                coche.gameObject.GetComponent<Collider>().enabled = true;
                

            }
            else
            {
                saltar = false;
            }
            if (andar == true)
                m_Animator.SetBool("andar", true);
        }
        if(speed == 0)
        {
            andar = false;


        }

        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true)
        {
            Debug.Log("Tomas Chupa Poyas");
            personMovement1.speed = 0;
            CanvasObject.GetComponent<Canvas>().enabled = true;
            spawner.spawnTime = 20;
            spawner2.spawnTime = 20;
            ArrowUp.minijuegoActivo += 1;

            speed = 0;

        }
       
        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);

        
    }

    void OnTriggerEnter()
    {
        // We set this variable to indicate that character is in trigger
        triggerEntered = true;
        Debug.Log("trigger entered");
    }
    void OnTriggerExit()
    {
        // We reset this variable since character is no longer in the trigger
        triggerEntered = false;
    }


   
}