using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExamples : MonoBehaviour
{
    public int[] edades = new int[4];
    public int[] notas;
    public int sumaDeLasEdades;
    public int cantReprobados;
    // Start is called before the first frame update
    void Start()
    {
        sumaDeLasEdades = SumaValoresDelArray(edades);
        cantReprobados = CantidadDeReprobados(notas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumaValoresDelArray(int[] arr)
    {
        int resultado = 0;

        for (int i = 0;i<arr.Length;i++ )
        {
            resultado = resultado + arr[i];
        }

        return resultado;
    }

    int CantidadDeReprobados(int[] valores)
    {
        int reprobados = 0;
        for (int i = 0; i< valores.Length; i++)
        {
            if (valores[i] < 6)
            {
                reprobados++;
            }
        }
        return reprobados;
    }
}
