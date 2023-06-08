using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlotsLine : MonoBehaviour
{
    [SerializeField] private Slot[] slot;
    public GameObject[] slots; // —сылка на GO слота
    public Sprite[] sprite_number;
    public Sprite sprite_stone;
    public Sprite sprite_tower;


    public int points;

    public bool foolLine = false;
    public bool slotStone = false;
    public bool slotTower = false;
    public bool generationSlots = true;

    private void Update()
    {
        if (generationSlots == true)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                int number = Random.Range(0, 12);
                if (number == 0)
                {
                    slot[i].number = 0;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                    //slot[i].text.gameObject.SetActive(false);
                }
                else if (number == 1)
                {
                    slot[i].number = 1;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 2)
                {
                    slot[i].number = 2;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 3)
                {
                    slot[i].number = 3;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 4)
                {
                    slot[i].number = 4;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 5)
                {
                    slot[i].number = 5;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 6)
                {
                    slot[i].number = 6;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 7)
                {
                    slot[i].number = 7;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 8)
                {
                    slot[i].number = 8;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 9)
                {
                    slot[i].number = 9;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 10 && slotStone == false)
                {
                    int stoneNumber = Random.Range(0, 10);
                    slot[i].number = stoneNumber;
                    slot[i].spriteRenderer.sprite = sprite_stone;
                    slot[i].text.text = slot[i].number.ToString();
                    slot[i].stone = 1;
                    slotStone = true;
                }
                else if (number == 10 && slotStone == true)
                {
                    int stoneNumber = Random.Range(0, 10);
                    slot[i].number = stoneNumber;
                    int num = stoneNumber;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 11 && slotTower == false)
                {
                    int towerNumber = Random.Range(0, 10);
                    slot[i].number = towerNumber;
                    slot[i].spriteRenderer.sprite = sprite_tower;
                    slot[i].text.text = slot[i].number.ToString();
                    slot[i].tower = 1;
                    slotTower = true;
                }
                else if (number == 11 && slotTower == true)
                {
                    int towerNumber = Random.Range(0, 10);
                    slot[i].number = towerNumber;
                    int num = towerNumber;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
            }
            points = 100;
            if(slotStone == true)
            {
                points += 25;
            }
            if (slotTower == true)
            {
                points += 50;
            }
            generationSlots = false;
        }
        if (foolLine == false)
        {
            if (slot[0].number == 0 && slot[1].number == 0
                 && slot[2].number == 0 && slot[3].number == 0
                  && slot[4].number == 0 && slot[5].number == 0
                   && slot[6].number == 0 && slot[7].number == 0
                    && slot[8].number == 0)
            {
                foolLine = true;
            }
            else if (slot[0].number == 1 && slot[1].number == 1
                 && slot[2].number == 1 && slot[3].number == 1
                  && slot[4].number == 1 && slot[5].number == 1
                   && slot[6].number == 1 && slot[7].number == 1
                    && slot[8].number == 1)
            {
                foolLine = true;
            }
            else if (slot[0].number == 2 && slot[1].number == 2
                 && slot[2].number == 2 && slot[3].number == 2
                  && slot[4].number == 2 && slot[5].number == 2
                   && slot[6].number == 2 && slot[7].number == 2
                    && slot[8].number == 2)
            {
                foolLine = true;
            }
            else if (slot[0].number == 3 && slot[1].number == 3
                 && slot[2].number == 3 && slot[3].number == 3
                  && slot[4].number == 3 && slot[5].number == 3
                   && slot[6].number == 3 && slot[7].number == 3
                    && slot[8].number == 3)
            {
                foolLine = true;
            }
            else if (slot[0].number == 4 && slot[1].number == 4
                 && slot[2].number == 4 && slot[3].number == 4
                  && slot[4].number == 4 && slot[5].number == 4
                   && slot[6].number == 4 && slot[7].number == 4
                    && slot[8].number == 4)
            {
                foolLine = true;
            }
            else if (slot[0].number == 5 && slot[1].number == 5
                 && slot[2].number == 5 && slot[3].number == 5
                  && slot[4].number == 5 && slot[5].number == 5
                   && slot[6].number == 5 && slot[7].number == 5
                    && slot[8].number == 5)
            {
                foolLine = true;
            }
            else if (slot[0].number == 6 && slot[1].number == 6
                 && slot[2].number == 6 && slot[3].number == 6
                  && slot[4].number == 6 && slot[5].number == 6
                   && slot[6].number == 6 && slot[7].number == 6
                    && slot[8].number == 6)
            {
                foolLine = true;
            }
            else if (slot[0].number == 7 && slot[1].number == 7
                 && slot[2].number == 7 && slot[3].number == 7
                  && slot[4].number == 7 && slot[5].number == 7
                   && slot[6].number == 7 && slot[7].number == 7
                    && slot[8].number == 7)
            {
                foolLine = true;
            }
            else if (slot[0].number == 8 && slot[1].number == 8
                 && slot[2].number == 8 && slot[3].number == 8
                  && slot[4].number == 8 && slot[5].number == 8
                   && slot[6].number == 8 && slot[7].number == 8
                    && slot[8].number == 8)
            {
                foolLine = true;
            }
            else if (slot[0].number == 9 && slot[1].number == 9
                 && slot[2].number == 9 && slot[3].number == 9
                  && slot[4].number == 9 && slot[5].number == 9
                   && slot[6].number == 9 && slot[7].number == 9
                    && slot[8].number == 9)
            {
                foolLine = true;
            }
        }
        if (foolLine == true)
        {
            Score.score += points;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trislot");
    }
}
