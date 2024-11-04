using UnityEngine;

public class exerciciocinco : MonoBehaviour
{
    [SerializeField] int pontosMissao = 60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pontosMissao >= 50)
        {
            print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
