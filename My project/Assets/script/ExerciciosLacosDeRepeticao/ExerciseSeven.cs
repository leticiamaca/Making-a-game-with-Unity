using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ExerciseSeven : MonoBehaviour
{
    List<int> num = new List<int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] num = { 1, 2, 3, 4, 5, 6 };
        print(num.Max());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
