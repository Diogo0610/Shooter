using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelDesign : MonoBehaviour
{
    public GameObject ParedeVertical;
    public GameObject ParedeHorizontal;
    public GameObject Inimigo;
    public GameObject Municao;
    void Start()
    {
        CubeVerHor();
        inimigo();
        municao();

        /*GameObject PV = GameObject.CreatePrimitive(PrimitiveType.Cube);
        PV.transform.position = new Vector3(0, 1.19f, 0);
        PV.transform.localScale = new Vector3(0.1f, 3.596f, 15.3194f);
        var PV_Renderer = PV.GetComponent<Renderer>();
        PV_Renderer.material.SetColor("_Color", Color.red);*/
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
        }
    }
    void CubeVerHor()
    {
        //Vertical
        Instantiate(ParedeVertical, new Vector3(-12.479f, 1.131f, 4.75f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(-12.479f, 1.131f, 24.1f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(-12.479f, 1.131f, 39.33f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(-4.1f, 1.131f, 4.75f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(-4.1f, 1.131f, 19.21f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(-4.1f, 1.131f, 37.81f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(21.4f, 1.131f, 0.3f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(21.4f, 1.131f, 15.6f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(21.4f, 1.131f, 34.9f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(12.5f, 1.131f, 1.2f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(12.5f, 1.131f, 19.73f), Quaternion.identity);
        Instantiate(ParedeVertical, new Vector3(12.5f, 1.131f, 34.9f), Quaternion.identity);

        //Horizontal
        Instantiate(ParedeHorizontal, new Vector3(-6.98f, 1.13f, 6.8f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(-15.3f, 1.13f, 3.86f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(-15.49f, 1.13f, 36.33f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(-9.48f, 1.13f, 32.35f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(24.2f, 1.13f, 2.3f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(24.2f, 1.13f, 32.8f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(15.2f, 1.13f, 3.86f), Quaternion.identity);
        Instantiate(ParedeHorizontal, new Vector3(15.2f, 1.13f, 30.9f), Quaternion.identity);

    }
    void inimigo()
    {
        Instantiate(Inimigo, new Vector3(-14.97174f, 1.34f, -0.9638484f), Quaternion.identity);
        Instantiate(Inimigo, new Vector3(-10.5333f, 1.34f, 36.23008f), Quaternion.identity);
        Instantiate(Inimigo, new Vector3(14.91757f, 1.34f, -2.022634f), Quaternion.identity);
        Instantiate(Inimigo, new Vector3(24.7f, 1.34f, 39), Quaternion.identity);
    }
    void municao() 
    {
        Instantiate(Municao, new Vector3(-5.86f, -0.565f, -0.38f), Quaternion.identity);
        Instantiate(Municao, new Vector3(-9.49f, -0.565f, 0.8f), Quaternion.identity);
        Instantiate(Municao, new Vector3(-8.47f, -0.565f, -2.12f), Quaternion.identity);
        Instantiate(Municao, new Vector3(-16.71f, -0.565f, 37.67f), Quaternion.identity);
        Instantiate(Municao, new Vector3(18.38f, -0.565f, 38.96f), Quaternion.identity);
        Instantiate(Municao, new Vector3(14.13f, -0.565f, 35.8f), Quaternion.identity);
        Instantiate(Municao, new Vector3(17.11f, -0.565f, 35.95f), Quaternion.identity);
        Instantiate(Municao, new Vector3(24.72f, -0.565f, -2.19f), Quaternion.identity);
    }
}
