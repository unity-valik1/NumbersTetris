using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private SlotsLine slotsLine;


    public GameObject prefab;
    private float time = 0f;
    private bool nextBullet = false;
    public GameObject fire;

    public int tower = 0;
    public int stone = 0;
    public int number = 0;
    public TMP_Text text;
    public SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            if (number == 0 && stone == 0 && tower == 0)
            {
                text.gameObject.SetActive(true);
                number++;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            else if (number >= 0 && number < 9 && stone == 0 && tower == 0)
            {
                number++;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            else if (number == 9 && stone == 0 && tower == 0)
            {
                //text.gameObject.SetActive(false);
                number = 0;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            if (number == 0 && stone == 0 && tower == 1)
            {
                text.gameObject.SetActive(true);
                number++;
                text.text = number.ToString();
            }
            else if (number >= 0 && number < 9 && stone == 0 && tower == 1)
            {
                number++;
                text.text = number.ToString();
            }
            else if (number == 9 && stone == 0 && tower == 1)
            {
                //text.gameObject.SetActive(false);
                number = 0;
                text.text = number.ToString();
            }
        }
    }

    private void Update()
    {
        if (tower == 1)
        {
            time += Time.deltaTime;

            if (time > 5f)
            {
                nextBullet = true;
            }
            if (nextBullet == true)
            {
                GameObject instance = Instantiate(prefab);
                instance.transform.position = fire.transform.position;
                time = 0f;
                nextBullet = false;
            }
        }
    }
}
