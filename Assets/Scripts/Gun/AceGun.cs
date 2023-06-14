using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AceGun : MonoBehaviour
{
    public int clickCount;
    public int targetClicks = 5;
    public GameObject particleEffectPrefab;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (IsTouchingObject(touch.position))
                {
                    clickCount++;

                    if (clickCount >= targetClicks)
                    {
                        // Вызов функции или выполнение действия после 5 нажатий
                        DoSomething();
                    }
                }
            }
        }
    }

    private bool IsTouchingObject(Vector2 touchPosition)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touchPosition), Vector2.zero);
        return hit.collider != null && hit.collider.gameObject == gameObject;
    }

    private void DoSomething()
    {
        Destroy(gameObject);
        Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
    }
    //void Update()

    //{ // Проверяем, есть ли клик мыши или касание пальцем
    //    if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
    //    {
    //        clickCount++;

    //        if (clickCount >= 5)
    //        {
    //            Destroy(gameObject);
    //            Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
    //        }
    //    }
    //}
}
