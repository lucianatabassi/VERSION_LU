using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOHO_ELIMINAR : MonoBehaviour
{
  
   private int cantMoho = 3;
    public GameObject corazon1;
   public GameObject corazon2;
    public AudioClip completado;
    public AudioSource audioSource;

    void Start()
    {
        corazon1.SetActive(false);
        corazon2.SetActive(false);
    }

    private void OnMouseDown()
    {
        // Este método se llama cuando haces clic en el objeto con este script.

        // Intenta encontrar el componente Collider2D del objeto que colisiona con la rama.
        Collider[] colliders = Physics.OverlapSphere(transform.position, 1.0f);
        

        foreach (Collider collider in colliders)
        {
            // Comprueba si el objeto que colisiona con la rama tiene una etiqueta "Moho".
            if (collider.CompareTag("Moho"))
            {
                // Si es moho, destrúyelo.
                Destroy(collider.gameObject);
                cantMoho--;
            }
        }

        if (cantMoho <= 0)
        {
            audioSource.PlayOneShot(completado);
            Destroy(gameObject);
            corazon1.SetActive(true);
            corazon2.SetActive(true);
            
        }


    }



    /* private void Update()
      {

          if (eliminando )
          {
              // Reduce gradualmente la escala del objeto del moho para simular su eliminación.
              transform.localScale -= Vector3.one * velocidadEliminacion * Time.deltaTime;

              // Si el objeto del moho se ha reducido lo suficiente, lo destruimos.
              if (transform.localScale.x <= 0f)
              {
                  Destroy(gameObject);
              }
          }
      }

      // Cuando la rama colisiona con el moho, activamos el proceso de eliminación.
      private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.CompareTag("Rama"))
          {
              eliminando = true;
          }
      }*/
}


