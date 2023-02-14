using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class healthbar : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private  Image total;
    private Image actual;

    // Start is called before the first frame update
    void Start()
    {
        total.fillAmount = playerHealth.currentHealth / 25;
    }

    // Update is called once per frame
    void Update()
    {
        actual.fillAmount = playerHealth.currentHealth / 25;
    }
}
