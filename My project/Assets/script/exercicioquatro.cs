using UnityEngine;

public class exercicioquatro : MonoBehaviour
{  [SerializeField] bool itensInventario;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            print(itensInventario == true ? "Usando pocao de vida" : "pocao indisponível");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
