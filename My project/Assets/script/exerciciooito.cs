using UnityEngine;

public class exerciciooito : MonoBehaviour
{
    [SerializeField] int horaInteira;
   [SerializeField] int cont = 0;
    [SerializeField]int dia;
    [SerializeField]float segundos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cont++;
        
        if (cont >= 20)
        {
            segundos++;
            cont = 0;
        }
        else if (segundos >= 10)
        {
            horaInteira++;
            segundos = 0;
        }
        else if (horaInteira >= 24)
        {
            horaInteira = 0;
            dia++;
        }
    }
}
