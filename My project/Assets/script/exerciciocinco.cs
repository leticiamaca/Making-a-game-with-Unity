using UnityEngine;

public class exerciciocinco : MonoBehaviour
{
    [SerializeField] int pontosMissao = 60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pontosMissao >= 50)
        {
            print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
