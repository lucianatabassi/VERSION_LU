using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOHO_ELIMINAR : MonoBehaviour
{
    //public float velocidadEliminacion = 1.0f; // Velocidad a la que se elimina el moho.
   // private bool eliminando = false;

    private void OnMouseDown()
    {
        // Este m�todo se llama cuando haces clic en el objeto con este script.

        // Intenta encontrar el componente Collider2D del objeto que colisiona con la rama.
        Collider[] colliders = Physics.OverlapSphere(transform.position, 1.0f);

        foreach (Collider collider in colliders)
        {
            // Comprueba si el objeto que colisiona con la rama tiene una etiqueta "Moho".
            if (collider.CompareTag("Moho"))
            {
                // Si es moho, destr�yelo.
                Destroy(collider.gameObject);
            }
        }
    }

    /* private void Update()
      {

          if (eliminando )
          {
              // Reduce gradualmente la escala del objeto del moho para simular su eliminaci�n.
              transform.localScale -= Vector3.one * velocidadEliminacion * Time.deltaTime;

              // Si el objeto del moho se ha reducido lo suficiente, lo destruimos.
              if (transform.localScale.x <= 0f)
              {
                  Destroy(gameObject);
              }
          }
      }

      // Cuando la rama colisiona con el moho, activamos el proceso de eliminaci�n.
      private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.CompareTag("Rama"))
          {
              eliminando = true;
          }
      }*/
}

