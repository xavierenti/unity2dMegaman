using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    // Start is called before the first frame update

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }


    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                GetComponent<player>().enabled = false;
                dead = true;
            }

        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
