using UnityEngine;

public class ExercicioQuatro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {

        
        for (int i = 0; i <= 7; i++) {
            if (i == 1) {
                print("Primeiro combo");
            }
         if (i == 2)
        {
            print("Segundo combo");
        };

            if (i == 3)
            {
                print("Terceiro combo");
            };
            if (i == 4)
            {
                print("Quarto combo");
            };
            if (i == 5)
            {
                print("Quinto combo");
            };
            if (i == 6)
            {
                print("Sexto combo");
            };
            if (i == 7)
            {
                print("Ataque de combos finalizado " + i*10);
            };


        }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
