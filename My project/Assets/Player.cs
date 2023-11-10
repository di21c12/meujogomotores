using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    private Rigidbody rb;

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log(message: "START");
        TryGetComponent(out rb);
    }

    // Update is called once per frame 

    void Update()
    {

        Debug.Log("UPDATE");
        float h = Input.GetAxis("Horizontal"); //-1 esquerda,0 nada, 1 direita
        float v = Input.GetAxis("Vertical"); // -1 pra tras, 0 nada, 1 pra frente

        Vector3 direcao = new Vector3(x: h, y: 0, z: v);
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);
        
       //
        }
    }
     