using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Score.score = 0;
            SceneManager.LoadScene("Gameplay");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
