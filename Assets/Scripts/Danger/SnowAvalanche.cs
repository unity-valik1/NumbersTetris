using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class SnowAvalanche : MonoBehaviour
{
    private float time1 = 0f;

    [SerializeField] Rigidbody2D rb;
    private void Update()
    {
        time1 += Time.deltaTime;
        if (time1 > 2)
        {
            rb.gravityScale = 5;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gun")
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
