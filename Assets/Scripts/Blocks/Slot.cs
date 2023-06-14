using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private SlotsLine slotsLine;

    public int number = 0;
    public TMP_Text text;
    public SpriteRenderer spriteRenderer;
    private float time = 0f;

    public int tower = 0;
    public GameObject prefab;
    public GameObject fire;
    private bool nextBullet = false;
    public GameObject particleEffectPrefab;

    public int stone = 0;
    [SerializeField] Animation anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BlockGunPlus")
        {
            if (number >= 0 && number < 5 && stone == 0 && tower == 0)
            {
                number++;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            else if (number == 5 && stone == 0 && tower == 0)
            {
                number = 0;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            if (number >= 0 && number < 5 && stone == 0 && tower == 1)
            {
                number++;
                text.text = number.ToString();
            }
            else if (number == 5 && stone == 0 && tower == 1)
            {
                number = 0;
                text.text = number.ToString();
            }
        }

        if (collision.gameObject.tag == "BlockGunMinus")
        {
            if (number == 0 && stone == 0 && tower == 0)
            {
                text.gameObject.SetActive(true);
                number = 5;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            else if (number >= 1 && number <= 5 && stone == 0 && tower == 0)
            {
                number--;
                int i = number;
                spriteRenderer.sprite = slotsLine.sprite_number[i];
                text.text = number.ToString();
            }
            if (number == 0 && stone == 0 && tower == 1)
            {
                text.gameObject.SetActive(true);
                number = 5;
                text.text = number.ToString();
            }
            else if (number >= 1 && number <= 5 && stone == 0 && tower == 1)
            {
                number--;
                text.text = number.ToString();
            }
        }
    }

    private void Update()
    {
        if (tower == 1)
        {
            time += Time.deltaTime;

            if (time > 8)
            {
                anim.Play("TowerBullet");
                nextBullet = true;
            }
            if (nextBullet == true)
            {
                Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
                GameObject instance = Instantiate(prefab);
                instance.transform.position = fire.transform.position;
                time = 0f;
                nextBullet = false;
            }
        }
    }
}
