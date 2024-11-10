using System;
using UnityEngine;

public class CarrotZazaBehaviour : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    int timer = 5;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("zaza"))
        {
            scoreManager.IncreaseScore();
            collision.gameObject.SetActive(false); // dit laat de zaza verdwijnen maar het is er nog wel :)
            Timer();
            scoreManager.Props();

        }
        
    }

    private void OnTriggerExit(Collider collision)
    {
        collision.gameObject.SetActive(true);
    }

    private void Timer()
    {
        
        for (int i = timer; i > 0; i-- )
        {
            timer -= 1;
        }
       
    }
}