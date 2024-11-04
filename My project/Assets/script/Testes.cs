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
                print("Vilão atacando");
                if (true)
                {
                    print("dano");
                }
                break;
            case 2:
                print("Vilão defende");
                break;

            case 3:
                print("Vilão");
                break;
            
default: Debug.Log("Valor não identificar");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
