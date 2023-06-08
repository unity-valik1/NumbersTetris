using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gun" || collision.gameObject.tag == "PlatformDestroy")
        {
            Destroy(gameObject);
        }
    }
}
