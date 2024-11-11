using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ExerciseEight : MonoBehaviour
{
    string programa;
    string nome = "Leticia";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = nome.Length; i > 0; i--)
        {
            programa += nome[i - 1];
        }
        print(programa);
    } 


    // Update is called once per frame
    void Update()
    {
        
    }
}
