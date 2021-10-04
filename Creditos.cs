using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Creditos : MonoBehaviour
{
    AudioSource Click;
    private void Start()
    {
        Click = GetComponent<AudioSource>();
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 40, 500, 60), "O Jogo foi desenvolvido por Diogo Bonilha Brandon.");
        GUI.Label(new Rect(10, 60, 500, 60), "Os efeitos sonoros foram providos pelo site MIXK!T.");
        GUI.Label(new Rect(10, 80, 500, 60), "Trilha sonora por Juhani Junkala.");
        
        if (GUI.Button(new Rect(10, 10, 100, 30), "VOLTAR"))
        {
            Click.Play();
            SceneManager.LoadScene(0);
        }
    }
}
