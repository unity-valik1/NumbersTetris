using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    public string targetTag = "YourTargetTag"; // ��� ��������� �������
    public float speed = 5f; // �������� �������� �������

    private Vector3 initialDirection; // ����������� �������� ������� ��� ��� ���������

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
        // ������� �������� ������ �� ����
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);

        // ���������, ������ �� ������
        if (targetObject != null)
        {
            // ��������� ��������� ����������� �������� �������
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
        // �������� ������ �������� �������
        Vector3 velocity = rb.velocity;

        // ���� �������� ������� ����� ����, �� ������������ ���
        if (velocity != Vector3.zero)
        {
            // ����������� ������ ��������
            velocity.Normalize();

            // ��������� ���� �������� �� ��������� � ����������� ��������
            Quaternion targetRotation = Quaternion.LookRotation(velocity);

            // ������ ������������ ������ � ����������� ��������
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }
}

