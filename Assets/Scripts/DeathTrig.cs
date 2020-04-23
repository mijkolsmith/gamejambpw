using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrig : MonoBehaviour
{

    public bool playerDead;

    void Start()
    {
        playerDead = false;
    }


    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (!playerDead && col.CompareTag("Player"))
            PlayerDeath();
    }

    void PlayerDeath()
    {
        playerDead = true;

        Debug.Log("ded lol");

        Invoke("RestartScene", 1f);
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
