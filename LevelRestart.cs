using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
    private Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(lives.can == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            lives.totalscore = 0;
            lives.can--;
            SceneManager.LoadScene(_scene.name);            
        }
    }
}
