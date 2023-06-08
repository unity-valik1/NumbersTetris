using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int life = 3;

    private float maxX = 3.5f;
    private float minX = -4.5f;
    public GameObject prefab;
    public GameObject gunGo;

    public void gun()
    {
        GameObject instance = Instantiate(prefab);
        instance.transform.position = this.transform.position;
    }
    public void GunGoLeft()
    {
        gunGo.transform.position -= new Vector3(1, 0, 0);
    }
    public void GunGoRight()
    {
        gunGo.transform.position += new Vector3(1, 0, 0);
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TowerBullet")
        {
            life -= 1;
        }

    }
}
