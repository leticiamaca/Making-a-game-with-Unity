using UnityEngine;

public class exercicionove : MonoBehaviour
{
    [SerializeField] int timeA;
    [SerializeField] int timeB;
    [SerializeField] int placar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timeA > timeB)
        {
            print("Time A venceu");
            placar = timeA;
        }
        else if (timeA < timeB)
        {
            print("Time B venceu");
            placar = timeB;
        }
        else if (timeA >= 3 && timeB >= 3)
        {
            print("Empate emocionante");
            placar = 1;
        }
        else if (timeA == timeB)
        {
            print("Empate");
            placar = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}