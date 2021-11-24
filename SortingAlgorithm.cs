using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SortingAlgorithm : MonoBehaviour
{
    int[] arr = new int[200];
    System.Random rand = new System.Random();
    

    void Start()
    {
        CreateArray();

        //PrintArray();

        SortArray();

        PrintArray();
    }
    private int[] CreateArray()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-100, 100);
        }

        return arr;
    }

    private void PrintArray()
    {
        foreach (var array in arr)
        {
            print(array);
        }
    }

    private int[] SortArray()
    {
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minNum = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[minNum] > arr[j])
                {
                    minNum = j;
                }
            }

            int currNum = arr[i];
            arr[i] = arr[minNum];
            arr[minNum] = currNum;

        }

        return arr;
    }
}
