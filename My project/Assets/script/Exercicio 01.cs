using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    [SerializeReference] int vidaJogador = 100;
    string resultado;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (vidaJogador <= 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Continua Vivo");
        }

        //Operador ternário
        // Condicao ? valor a ser chamado caso verdadeiro : caso falso

        resultado = (vidaJogador > 0) ? "Personagem Vivo!" : "Gamer Over...";
        print(resultado);
       
    }


    // Update is called once per frame
    void Update()
    { 
    }
}
