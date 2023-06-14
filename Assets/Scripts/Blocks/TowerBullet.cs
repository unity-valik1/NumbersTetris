using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    public string targetTag = "YourTargetTag"; // Тег заданного объекта
    public float speed = 5f; // Скорость движения прифаба

    private Vector3 initialDirection; // Направление движения прифаба при его появлении

    private Rigidbody2D rb;
    public GameObject particleEffectPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gun")
        {
            Destroy(gameObject);
            Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Находим заданный объект по тегу
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);

        // Проверяем, найден ли объект
        if (targetObject != null)
        {
            // Вычисляем начальное направление движения прифаба
            initialDirection = targetObject.transform.position - transform.position;
            initialDirection.Normalize();
        }
        else
        {
            Debug.LogWarning("Target object not found!");
        }
    }
    void Update()
    {
        transform.position += initialDirection * speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        // Получаем вектор скорости объекта
        Vector3 velocity = rb.velocity;

        // Если скорость объекта равна нулю, не поворачиваем его
        if (velocity != Vector3.zero)
        {
            // Нормализуем вектор скорости
            velocity.Normalize();

            // Вычисляем угол поворота по отношению к направлению движения
            Quaternion targetRotation = Quaternion.LookRotation(velocity);

            // Плавно поворачиваем объект в направлении движения
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }
}

