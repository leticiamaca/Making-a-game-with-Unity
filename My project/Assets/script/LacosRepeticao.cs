using UnityEngine;

public class LacosRepeticao : MonoBehaviour

{//For -> é utilizado quando se sabe a quantidade de repeticoes
 //While ou Do While -> É utilizado quando não se sabe a quantidade de repeticoes
 // Foreach -> Usado em listas ou arrays para executar uma operacao para cada item da lista
 //Array -> É uma lista
 // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //for(inicializador; codicão; incremento/decremento)
        for (int i = 0; i <= 10; i++)
        {
            //if (i == 5)
            //{
            //    break;
            //};
            if (i == 6)
            {
                continue;
            }
            print(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
