using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_USUARIO : MonoBehaviour
{
    public CharacterController controller;
    public float vel = 10f;
    public float gravedad = -9.8f;
    private Vector3 mover;
    // public Transform groundCheck;
    // public float groundDistance = 0.3f;
    //public LayerMask groundMask;

    Vector3 velocity;
    // bool isGrounded;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

         if (isGrounded && velocity.y < 0)
         {
             velocity.y = -2f;
         }*/

        float x = Input.GetAxis("Horizontal"); //con esta linea de codigo unity ya sabe cuales son las teclas por defecto que se usan para moverse
        float z = Input.GetAxis("Vertical"); //lo de arriba

        mover = transform.right * x + transform.forward * z;

        Gravedad();

        controller.Move(mover * vel * Time.deltaTime);

    }

    void Gravedad()
    {
        mover.y = gravedad * Time.deltaTime;
    }
}
