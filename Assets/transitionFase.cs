using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionFase : MonoBehaviour
{
    public string path;
    float contador;
    // Use this for initialization
    void Start()
    {
        contador = 0;
    }


    void OnTriggerStay2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Player") && MainGame.instance.noMoreEnemies)
        {
             StartCounting();
            //Invoke("TrocaCena", 2);
        }
    }

    void TrocaCena()
    {
        SceneManager.LoadScene(path);
    }

    void StartCounting()
    {
        contador += Time.deltaTime*3;
        print(contador);
        if (contador > 2.0f)
        {
            SceneManager.LoadScene(path);
        }
    }
     
}
