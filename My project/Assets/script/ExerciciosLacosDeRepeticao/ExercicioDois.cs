using System;
using UnityEngine;

public class ExercicioDois : MonoBehaviour
{
    int combo = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = combo; i <= 5; i++)
        {
            print(i * 2);
            if (i == 5) {
                print("Combo de ataque finalizado");
            };
        }



        // Update is called once per frame
        void Update()
        {

        }
    }
}
 
            
