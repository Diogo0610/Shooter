using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Chefe : MonoBehaviour
{
    int Vida;
    AudioSource kill;
    bool ativarSom = false;
    void Start()
    {
        Vida = 5;
        kill = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Vida <= 0)
        {
            ativarSom = true;
            kill.Play();
            if (ativarSom == true)
            {
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projetil")
        {
            Vida--;
        }
    }
}
