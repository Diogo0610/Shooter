using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municao : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.tag == "Player")
       {
            Destroy(gameObject);
       }
   }
}
