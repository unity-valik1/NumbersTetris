using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlotsLine : MonoBehaviour
{
    [SerializeField] private Slot[] slot;
    public GameObject[] slots; // Ссылка на GO слота
    public Sprite[] sprite_number;
    public Sprite sprite_stone;
    public Sprite sprite_tower;
    public GameObject particleEffectPrefab;

    public GameObject prefabX2;
    public GameObject prefabMinus;
    public GameObject prefabPlus;
    public GameObject prefabLifes;

    public int foolBlock;
    public int points;

    public bool foolLine = false;
    public bool slotStone = false;
    public bool slotTower = false;
    public bool generationSlots = true;
    public int foolPickUp = 0;

    public float duration = 2f; // Продолжительность перемещения в секундах
    private void Update()
    {
        if (generationSlots == true)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                int number = Random.Range(0, 8);
                if (number == 0)
                {
                    slot[i].number = number;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 1)
                {
                    slot[i].number = number;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 2)
                {
                    slot[i].number = number;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 3)
                {
                    slot[i].number = number;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 4)
                {
                    slot[i].number = number;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 5)
                {
                    slot[i].number = number;
                    int num = slot[i].number;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 6 && slotStone == false)
                {
                    int stoneNumber = Random.Range(0, 6);
                    slot[i].number = stoneNumber;
                    slot[i].spriteRenderer.sprite = sprite_stone;
                    slot[i].text.text = slot[i].number.ToString();
                    slot[i].stone = 1;
                    slotStone = true;
                }
                else if (number == 6 && slotStone == true)
                {
                    int stoneNumber = Random.Range(0, 6);
                    slot[i].number = stoneNumber;
                    int num = stoneNumber;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
                else if (number == 7 && slotTower == false)
                {
                    int towerNumber = Random.Range(0, 6);
                    slot[i].number = towerNumber;
                    slot[i].spriteRenderer.sprite = sprite_tower;
                    slot[i].text.text = slot[i].number.ToString();
                    slot[i].tower = 1;
                    slotTower = true;
                }
                else if (number == 7 && slotTower == true)
                {
                    int towerNumber = Random.Range(0, 6);
                    slot[i].number = towerNumber;
                    int num = towerNumber;
                    slot[i].spriteRenderer.sprite = sprite_number[num];
                    slot[i].text.text = slot[i].number.ToString();
                }
            }
            points = 100;
            if (slotStone == true)
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
             && slot[6].number == 0)
            {
                foolLine = true;
            }
            else if (slot[0].number == 1 && slot[1].number == 1
             && slot[2].number == 1 && slot[3].number == 1
             && slot[4].number == 1 && slot[5].number == 1
             && slot[6].number == 1)
            {
                foolLine = true;
            }
            else if (slot[0].number == 2 && slot[1].number == 2
             && slot[2].number == 2 && slot[3].number == 2
             && slot[4].number == 2 && slot[5].number == 2
             && slot[6].number == 2)
            {
                foolLine = true;
            }
            else if (slot[0].number == 3 && slot[1].number == 3
             && slot[2].number == 3 && slot[3].number == 3
             && slot[4].number == 3 && slot[5].number == 3
             && slot[6].number == 3)
            {
                foolLine = true;
            }
            else if (slot[0].number == 4 && slot[1].number == 4
             && slot[2].number == 4 && slot[3].number == 4
             && slot[4].number == 4 && slot[5].number == 4
             && slot[6].number == 4)
            {
                foolLine = true;
            }
            else if (slot[0].number == 5 && slot[1].number == 5
             && slot[2].number == 5 && slot[3].number == 5
             && slot[4].number == 5 && slot[5].number == 5
             && slot[6].number == 5)
            {
                foolLine = true;
            }
        }

        if (foolLine == true)
        {
            if(PickUpTime.x2Score == true)
            {
                Score.score += (points * 2);
            }
            else
            {
                Score.score += points;
            }
            Destroy(gameObject);
            Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);


            int number = Random.Range(0, 7);
            for (int i = 0; i < slots.Length; i++)
            {
                int number1 = Random.Range(0, 8);
                if (number1 == 0 || number1 == 1)
                {
                    if (number == i && foolPickUp == 0)
                    {
                        GameObject prefabx2 = Instantiate(prefabX2);
                        prefabx2.transform.position = slots[i].transform.position;
                        foolPickUp = 1;
                    }
                }
                else if (number1 == 2 || number1 == 3)
                {
                    if (number == i && foolPickUp == 0)
                    {
                        GameObject prefabminus = Instantiate(prefabMinus);
                        prefabminus.transform.position = slots[i].transform.position;
                        foolPickUp = 1;
                    }
                }
                else if (number1 == 4 || number1 == 5)
                {
                    if (number == i && foolPickUp == 0)
                    {
                        GameObject prefabplus = Instantiate(prefabPlus);
                        prefabplus.transform.position = slots[i].transform.position;
                        foolPickUp = 1;
                    }
                }
                else if (number1 == 6 || number1 == 7)
                {
                    if (number == i && foolPickUp == 0)
                    {
                        GameObject prefablifes = Instantiate(prefabLifes);
                        prefablifes.transform.position = slots[i].transform.position;
                        foolPickUp = 1;
                    }
                }
            }
        }

        if (NewBlockGeneration.newLine == 1)
        {
            StartCoroutine(MoveObject());
        }
    }
    private IEnumerator MoveObject()
    {
        Vector3 startPositionGeneration = transform.position;
        Vector3 targetPosition = startPositionGeneration - new Vector3(0f, 1f, 0f);

        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            transform.position = Vector3.Lerp(startPositionGeneration, targetPosition, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trislot");
    }
}
