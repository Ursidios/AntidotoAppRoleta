using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorRoleta : MonoBehaviour
{
    
    public GameObject Roleta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Verificador de colisão que detecta a fatia selecionada e passa seu valor para RoletaScript
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("FatiaRoleta"))
        {
            Roleta.GetComponent<RoletaScript>().
                RoletaParou(other.gameObject.GetComponent<ArmazemValorFatia>().ValorFatia);        
            print(other.gameObject.name);
        }
    }
}
