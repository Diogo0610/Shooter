using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
    public float velocidade;
    public float sensitivity;
    public int municao, Chave;
    bool semLimite, semMunicao;
    public GameObject Bala, Chefe;
    AudioSource hit;
    bool mensagem = false;
    void Start()
    {
        municao = 10;
        semLimite = false;
        semMunicao = false;
        Chave = 0;
        hit = GetComponent<AudioSource>();
    }
    void Update()
    {
        Movimentacao();
        Validacao();
        Arma();
    }
    void Movimentacao()
    {
        float vertical = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);

        float rotateHorizontal = Input.GetAxis("Mouse X");       
        transform.RotateAround(transform.position, -Vector3.up, rotateHorizontal * sensitivity);
        //float rotateVertical = Input.GetAxis("Mouse Y");
        //transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);
    }
    void Arma()
    {
        if (Input.GetKeyDown("f"))
        {
            if (municao !=0)
            {
                Instantiate(Bala, transform.position + new Vector3 (0, 0.406f, 0), transform.rotation);
                municao--;
                hit.Play();
            }
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 25, 100, 20), "Munição: " + municao);
        if (semLimite == true)
        {
            GUI.Label(new Rect(10, 40, 100, 20), "Munição Cheia");
        }
        if (semMunicao == true)
        {
            GUI.Label(new Rect(10, 40, 100, 20), "Sem Munição");
        }

        GUI.Label(new Rect(10, 10, 100, 20), "Chaves: " + Chave); 
        
        if (mensagem == true)
        {
            GUI.Label(new Rect(300, 10, 350, 30), "O Chefe Chegou!");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
           if (collision.gameObject.tag == "Municao")
           {
               if (municao <= 21)
               {
                municao = municao + 5;
               }
           }
           if (collision.gameObject.tag == "Coletavel")
           {
            Chave++;
           }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            if (Chave >= 4)
            {
                    Instantiate(Chefe, new Vector3(3.72f, 3.16f, 1.4f), Quaternion.identity);
                    Debug.Log("Done");
                mensagem = true;
            }
        }
    }
    void Validacao()
    {
        //Validacao da municao
        if (municao >= 25)
        {
            semLimite = true;
        }
        else
        {
            semLimite = false;
        }
        
        //Sem municao
        if (municao == 0)
        {
            semMunicao = true;
        }
        else
        {
            semMunicao = false;
        }
    }
}