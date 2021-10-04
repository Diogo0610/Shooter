using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Tutorial : MonoBehaviour
{
    AudioSource Click;
    private void Start()
    {
        Click = GetComponent<AudioSource>();
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 40, 500, 60), "Para movimentar o personagem, pressione as teclas A,S,W,D.");
        GUI.Label(new Rect(10, 60, 500, 60), "Para girar o personagem, utilize o mouse.");
        GUI.Label(new Rect(10, 80, 500, 60), "Para atirar, pressione a tecla F");
        GUI.Label(new Rect(10, 100, 500, 60), "Para coletar as munições e as chaves, passe por cima delas.");
        GUI.Label(new Rect(10, 120, 500, 60), "Para voltar ao menu, pressione a tecla ESC durante o jogo.");
        GUI.Label(new Rect(10, 140, 500, 60), "Para chamar o chefe, vá até o terminal verde.");
        GUI.Label(new Rect(10, 160, 500, 60), "O chefe possui 5 pontos de vida, cada bala tira 1 ponto.");

        if (GUI.Button(new Rect(10, 10, 100, 30), "VOLTAR"))
        {
            Click.Play();
            SceneManager.LoadScene(0);
        }
        if (GUI.Button(new Rect(120, 10, 100, 30), "JOGAR"))
        {
            Click.Play();
            SceneManager.LoadScene(2);
        }
    }
}
