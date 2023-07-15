using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class krajlevela : MonoBehaviour
{
    

    private bool levelCompleted = false;

    [SerializeField] private AudioSource finishSound;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "cikica" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
