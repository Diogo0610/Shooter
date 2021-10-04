using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Inimigo : MonoBehaviour
{
    public Transform target;
    bool Vivo = true;
    public GameObject Coletavel;
    AudioSource kill;
    bool ativarSom = false;
    private void Start()
    {
        kill = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;

        if (ativarSom == true) 
        {
            kill.Play();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projetil")
        {
            Vivo = false;
            Instantiate(Coletavel, transform.position + new Vector3(0, -0.224f, 0), transform.rotation);
            ativarSom = true;
            if (Vivo == false)
            {
                Destroy(gameObject);
            }
                
        }
    }
}
