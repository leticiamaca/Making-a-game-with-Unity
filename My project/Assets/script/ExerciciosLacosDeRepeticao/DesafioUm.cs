using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DesafioUm : MonoBehaviour
{
    [SerializeField] string nome;
    int consoantes = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string vogal = "aeiouAEIOU";
        foreach(char c in nome) {

            if(char.IsLetter(c) && !vogal.Contains(c)){
                consoantes++;
            } }
        print(consoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
