using UnityEngine;

public class exerciciosete : MonoBehaviour
{
    [SerializeField] int faceDados = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        faceDados = Random.Range(1,
6);
        print(faceDados);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
