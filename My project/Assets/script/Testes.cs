using UnityEngine;

public class Testes : MonoBehaviour
{
    [SerializeField] int estadoVilao = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (estadoVilao)
        {
            case 1:
                print("Vil�o atacando");
                if (true)
                {
                    print("dano");
                }
                break;
            case 2:
                print("Vil�o defende");
                break;

            case 3:
                print("Vil�o");
                break;
            
default: Debug.Log("Valor n�o identificar");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
