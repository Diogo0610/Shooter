using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Bala : MonoBehaviour
{
    float velocidade;
    AudioSource hit;
    private void Start()
    {
       hit = GetComponent<AudioSource>();
    }
    void FixedUpdate()
    {
        velocidade = 20 * Time.deltaTime;
        transform.Translate(0, 0, velocidade);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Inimigo")
        {
            Destroy(gameObject);
            hit.Play();
        }
    }
}
