using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishsound;
    private bool LevelCompleted = false;
    // Start is called before the first frame update
    private void Start()
    {
        finishsound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !LevelCompleted)
        {
            finishsound.Play();
            LevelCompleted = true;
            Invoke("CompleteLevel", 2f);
           
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
