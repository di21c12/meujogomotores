using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria, clipVitoriaUp;
    private AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;
        
        hud.text = $"Moedas Restantes: {restantes}";
        
    }

    public void SubtrairMoedas(int valor)
    {
        source.PlayOneShot(clipMoeda);
        restantes -= valor;
        hud.text = $"Moedas Restantes:{restantes}";
        
        if (restantes <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "Parabéns!!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
            source.PlayOneShot(clipVitoriaUp);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
