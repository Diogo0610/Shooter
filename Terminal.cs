using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    bool objetivo = true;
    AudioSource aviso;
    private void Start()
    {
        aviso = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objetivo = false;
        }
    }
    void OnGUI()
    {
        if (objetivo == true)
        {
            GUI.Label(new Rect(180, 10, 500, 30), "Derrote 4 inimigos para coletar suas chaves e invocar o chefe!");
        }
    }
}