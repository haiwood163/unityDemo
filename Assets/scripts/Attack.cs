using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Timers;
using System;

public class Attack : MonoBehaviour
{

    private bool _canAttack = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    public void DealDamage(Collider2D collision)
    {
        if (!_canAttack) return;

        if (collision.CompareTag("Player"))
        {
            var damageable = collision.GetComponent<Damagable>();
            damageable.TakeDamge(1);
            TimersManager.SetTimer(this, 1, CanAttack);
            this._canAttack = false;
        }

    }

    private void CanAttack()
    {
        this._canAttack = true;
    }
}
