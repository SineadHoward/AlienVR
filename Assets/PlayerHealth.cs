using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private GameObject _player;
    public RectTransform gameOverBox;

    public event EventHandler gameOver;

    public Text gameOverText;
    public float currentHealth = 10;

    void Start()
    {
    }

    public void TakeDamage(float damage)
    {
        System.Diagnostics.Debug.WriteLine("Take damage? ");
        //_animator.SetTrigger("get a hit (R)");
        if (currentHealth <= 0)
        {
            return;
        }

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    

    private void Death()
    {
        // _animator.SetTrigger("dead");.SetBool("levelFinished", true);
        //_animator.SetBool("isDead", true);
        gameOverBox.gameObject.SetActive(true);
    }
}
