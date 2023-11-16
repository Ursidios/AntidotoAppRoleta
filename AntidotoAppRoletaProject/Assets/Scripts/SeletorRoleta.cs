using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorRoleta : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Roleta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
