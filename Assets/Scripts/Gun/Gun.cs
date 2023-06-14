using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public List<GameObject> lifes;
    public int life = 5;

    private float maxX = 2.5f;
    private float minX = -3.5f;
    public GameObject prefabPlus;
    public GameObject prefabMinus;
    public GameObject gunGo;
    public GameObject gameOver;
    public GameObject prefabAceGun;


    public Button[] gamePad;

    public string tagToCheck = "AceGun";

    public void gun()
    {
        if(PickUpTime.minusAndPlus == true)
        {
            GameObject instance = Instantiate(prefabPlus);
            instance.transform.position = this.transform.position;
        }
        else
        {
            GameObject instance = Instantiate(prefabMinus);
            instance.transform.position = this.transform.position;
        }
    }
    public void GunGoLeft()
    {
        gunGo.transform.position -= new Vector3(1, 0, 0);
    }
    public void GunGoRight()
    {
        gunGo.transform.position += new Vector3(1, 0, 0);
    }
    public void UpdateLifes()
    {
        for (int index = 0; index < lifes.Count; index++)
        {
            if (index < life)
            {
                lifes[index].SetActive(true);
            }
            else
            {
                lifes[index].SetActive(false);
            }
        }
    }
    private void Update()
    {        // Получаем текущую позицию объекта
        Vector3 currentPosition = transform.position;

        // Вычисляем новую позицию объекта с учетом пользовательского ввода или другой логики
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float newX = currentPosition.x + moveX;

        // Ограничиваем новую позицию по оси X в заданном диапазоне
        float clampedX = Mathf.Clamp(newX, minX, maxX);

        // Обновляем позицию объекта
        transform.position = new Vector3(clampedX, currentPosition.y, currentPosition.z);

        GameObject[] aceGun = GameObject.FindGameObjectsWithTag(tagToCheck); 
        if (aceGun.Length > 0)
        {

        }
        else
        {
            for (int i = 0; i < gamePad.Length; i++)
            {
                gamePad[i].interactable = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TowerBullet")
        {
            life -= 1;
            UpdateLifes();
            if (life == 0)
            {
                gameOver.gameObject.SetActive(true);
            }
        }

        if (collision.gameObject.tag == "SnowAvalanche")
        {
            for (int i = 0; i < gamePad.Length; i++)
            {
                gamePad[i].interactable = false;
            }

            GameObject instance = Instantiate(prefabAceGun);
            instance.transform.position = this.transform.position;
        }

        if (collision.gameObject.tag == "X2Score")
        {
            PickUpTime.timeX2Score = 0;
            PickUpTime.x2Score = true;
        }
        if (collision.gameObject.tag == "Minus")
        {
            PickUpTime.timeminusAndPlus = 0;
            PickUpTime.minusAndPlus = false;
        }
        if (collision.gameObject.tag == "Plus")
        {
            PickUpTime.timeminusAndPlus = 0;
            PickUpTime.minusAndPlus = true;
        }
        if (collision.gameObject.tag == "Lifes")
        {
            life += 1;
            if(life > 3)
            {
                life = 3;
            }
            UpdateLifes();
        }
    }
}
