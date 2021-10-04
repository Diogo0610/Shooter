using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Menu : MonoBehaviour
{
    AudioSource Click;
    void Start()
    {
        Click = GetComponent<AudioSource>();
    }
    void OnGUI()
    {
        GUI.Box(new Rect(470, 200, 200, 190), "MENU");

        if (GUI.Button(new Rect(520, 230, 100, 30), "TUTORIAL"))
        {
            Click.Play();
            SceneManager.LoadScene(1);

        }
        else if (GUI.Button(new Rect(520, 280, 100, 30), "JOGAR"))
        {
            Click.Play();
            SceneManager.LoadScene(2);
        }
        else if (GUI.Button(new Rect(520, 330, 100, 30), "CRÉDITOS"))
        {
            Click.Play();
            SceneManager.LoadScene(3);
        }
    }
}
