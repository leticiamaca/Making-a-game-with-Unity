using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            if (i == 1)
            {
                print("Fase 1, dificuldade 5");

            }
            if (i == 2)
            {
                print("Fase 2, dificuldade 10");

            }
            if (i == 3)
            {
                print("Fase 3, dificuldade 15");

            }
            if (i == 4)
            {
                print("Fase 4, dificuldade 20");

            }
            if (i == 5)
            {
                print("Fase 5, dificuldade 25");

            }
            if (i == 6)
            {
                print("Fase 6, dificuldade 30");

            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
