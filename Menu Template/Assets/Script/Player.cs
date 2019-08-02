using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{

    public float runSpeed = 5f;
    public float JumpSpeed = 5f;
    public Rigidbody2D myRigidBody;
    public Animator myAnimator;
    public BoxCollider2D myFeetCollider;
    public CapsuleCollider2D myBodyCollider;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myFeetCollider = GetComponent<BoxCollider2D>();
        myBodyCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
        Jump();
    }


    void Run()
    {
        //Obtener el float (decimal) del control que va de -1 a 1
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");

        //Inicializar un vector de dos dimensiones que solo modifica el componente x
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);

        //Asignar la nueva velocidad a mi rigid body
        myRigidBody.velocity = playerVelocity;

        
        
    }

    void FlipSprite()
    {

        /*Vrificar si existe velocidad en x independientemente del signo (por eso usamos valor absoluto)
         * Guardamos esta verificacion como un valor booleano (true/false)
         */
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > 0;

        //Preguntamos si esa condicion es verdadera
        if (playerHasHorizontalSpeed)
        {
            //Aplicar animacion de correr seteando la condicion de "Running" del animator
            myAnimator.SetBool("Running", true);

            //Si si es verdadera, toma el signo de la velocidad en x y altera la escala en esa dimension
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1f);
        }
        else
            myAnimator.SetBool("Running", false);
    }

    void Jump()
    {

        if (!myFeetCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }



        // Obtener el boobleano (true/false) del boton representado por el tag "Jump" que va de -1 a 1
        bool isJumpButtonPressed = CrossPlatformInputManager.GetButtonDown("Jump");
        if (isJumpButtonPressed)
        {
            myAnimator.SetTrigger("Jumping");
            Vector2 jumpVelocity = new Vector2(0, JumpSpeed);
            //Sumarle a la velocidad que ya tiene, mi nuevo vector de velocidad
            myRigidBody.velocity += jumpVelocity;

        }
    }



}

