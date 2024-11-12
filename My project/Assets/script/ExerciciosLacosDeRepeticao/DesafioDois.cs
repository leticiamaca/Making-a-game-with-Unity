using System;
using UnityEngine;

public class DesafioDois : MonoBehaviour
{
    [SerializeField] int dia;
    [SerializeField] int mes;
    [SerializeField] int ano;
    DateTime dataAtual = DateTime.Now;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int diaHoje = dataAtual.Day;
        int mesHoje = dataAtual.Month;
        int anoAtual = dataAtual.Year;

        int seuAnoDeNascimento = anoAtual - ano;
        int seuMes = mesHoje - mes;
        int seuAno = anoAtual - ano;
        int seuDia = diaHoje - dia;

        if(seuMes < 0)
        {
            seuMes += 12;
            seuAno--;
        }

        
        if (seuDia < 0){
            diaHoje += 30;
            seuMes--;
                }
        print("Voce viveu " + seuAnoDeNascimento + " ano(s) " + seuMes + " Meses " + seuDia + " dias");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
