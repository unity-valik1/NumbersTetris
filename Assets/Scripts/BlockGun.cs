using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlockGun : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot" || collision.gameObject.tag == "PlatformDestroy")
        {
            Destroy(gameObject);
        }
    }
}
