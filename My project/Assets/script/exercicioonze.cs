using UnityEngine;

public class exercicioonze : MonoBehaviour
{
    [SerializeField] int estadoJogador = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (estadoJogador)
        {
            case 1:
                if (estadoJogador == 1)
                {
                    print("Olá! Seja muito bem vindo...");
                }
                break;
            case 2:
                if (estadoJogador == 2)
                {
                    print("O que voce gostaria de comprar?");
                }
                break;
            case 3:
                if (estadoJogador == 3)
                {
                    print("Olá, gostaria de alugar um quarto?");
                }
                break;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
