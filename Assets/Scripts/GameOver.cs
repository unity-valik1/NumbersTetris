using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Score score;
    public GameObject gameOver;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOver.gameObject.SetActive(true);
    }
    public void ReloadScene()
    {
        Score.score = 0;
        // Получаем имя текущей активной сцены
        string sceneName = SceneManager.GetActiveScene().name;

        // Загружаем сцену снова по ее имени
        SceneManager.LoadScene(sceneName);
    }
}
