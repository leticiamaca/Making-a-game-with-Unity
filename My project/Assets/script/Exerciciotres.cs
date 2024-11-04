using UnityEngine;

public class Exerciciotres : MonoBehaviour
{
    [SerializeReference] bool powerUp;
    [SerializeReference] bool jogadorVivo;
    [SerializeReference] int vidaJogador;
    float poderPowerup = 0.5f;
    int vidaMaxima = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerUp == true && jogadorVivo == false)
        {
            vidaJogador = (int)(vidaMaxima * poderPowerup);
            Debug.Log("Ainda não, vida atual " + vidaJogador);

        }
        else { Debug.Log("Game Over"); };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
