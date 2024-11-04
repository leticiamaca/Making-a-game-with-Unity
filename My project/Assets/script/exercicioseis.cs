using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class exercicioseis : MonoBehaviour
{

    [SerializeField] bool guerreiro;
    [SerializeField] bool mago;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else if (mago == true)
        {
            print("Mago escolhido");
        } else if (guerreiro == true && mago == true || guerreiro == false && mago == false)
        {
            print("Erro ao escolher os personagens, Não é possível escolher dois ao mesmo tempo ou prosseguir sem escolher nenhum");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
