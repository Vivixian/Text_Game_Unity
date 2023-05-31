using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TextGame : MonoBehaviour
{
    // Program zgaduje liczbe wymyslona przez gracza
    // Mamy przedzial liczb od 1 do 1000
    // Uzytkownik odpowiada, czy liczba jest mniejsza, wieksza lub rowna
    // ALGORYTM -> wyszukiwanie binarne                    \
    int min = 1;
    int max = 1000;
    int shoot = 500; 

    void Start()
    {
        Debug.Log("Witaj w grze - Pomysl w glowie liczbe od 1 do 1000");
        max = 1001;
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od 500?");
        // print string
        // Nacisnij gona strzalke aby odpowiedziec, ze wieksza
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + "?");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + "?"); 
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgadl liczbe");
        }
    }
}