using UnityEngine;

public class ExerciseSix : MonoBehaviour
{
    int num;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int num = 0; num <= 1000; num++) {
 if (num % 3 == 0 && num % 5 == 0)
            {
                print( num + " Fizz Buzz");}
            else if (num % 3 == 0)
            {
                print(num + " Fizz");
            }
           
            
            else if (num % 5 == 0)
            {
                print(num + " Buzz");
            } 
            
            else {
                print(num + " Não é divisivel por nenhum...");
            } }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
