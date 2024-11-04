using UnityEngine;

public class Exerciciodois : MonoBehaviour
{
    [SerializeReference] bool powerUp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerUp == true)
        {
          Debug.Log("Power-up coletado");
        }
        else
        {
          Debug.Log("Nenhum PowerUp encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
