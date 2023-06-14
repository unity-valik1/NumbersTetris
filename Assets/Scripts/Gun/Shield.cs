using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] Gun gun;
    public GameObject shieldImg;
    public void ActivateTheShield()
    {
        if (gun.shield == true)
        {

        }
        else
        {
            gun.shield = true;
            shieldImg.gameObject.SetActive(true);
        }
    }
}
