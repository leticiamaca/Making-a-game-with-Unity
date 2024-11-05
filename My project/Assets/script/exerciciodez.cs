using Unity.VisualScripting;
using UnityEngine;

public class exerciciodez : MonoBehaviour
{
    [SerializeField] int itemColetado = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (itemColetado)
        {
            case 1:
                if (itemColetado == 1)
                {
                    print("PowerUp coletado - poder de reviver");
                }
                break;
            case 2:
                if (itemColetado == 2)
                {
                    print("Pocao coletada - poderes adicionais");
                } break;
            case 3:
                if (itemColetado == 3)
                {
                    print("Moeda coletada - comprar suprimentos");
                }break;
            default:
                print("item nao identificado");
                break;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
