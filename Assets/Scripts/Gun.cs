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
    {        // �������� ������� ������� �������
        Vector3 currentPosition = transform.position;

        // ��������� ����� ������� ������� � ������ ����������������� ����� ��� ������ ������
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float newX = currentPosition.x + moveX;

        // ������������ ����� ������� �� ��� X � �������� ���������
        float clampedX = Mathf.Clamp(newX, minX, maxX);

        // ��������� ������� �������
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
