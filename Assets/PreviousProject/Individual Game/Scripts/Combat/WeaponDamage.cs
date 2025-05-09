using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    [SerializeField] private Collider myCollider;
    public static event Action<Collider, GameObject> OnAnyHitEnemy;
    private GameObject attacker;

    //private int damage;
    [SerializeField ]private float knockback;
    private List<Collider> alreadyCollidedWith = new List<Collider>();

    private void OnEnable()
    {
        alreadyCollidedWith.Clear();
    }
    public void SetAttacker(GameObject attacker)
    {
        this.attacker = attacker;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other == myCollider)
        {
            return;
        }

        if (alreadyCollidedWith.Contains(other))
        {
            return;
        }

        alreadyCollidedWith.Add(other);

        //if (other.TryGetComponent<Health>(out Health health))
        //{
        //    health.DealDamage(damage);
        //}

        if(other.TryGetComponent<ForceReceiver>(out ForceReceiver forceReceiver))
        {
            Vector3 direction = (other.transform.position - myCollider.transform.position).normalized+ Vector3.up * 0.2f;
            forceReceiver.AddForce(direction * knockback);
            OnAnyHitEnemy?.Invoke(other, attacker);
        }
    }

    public void SetAttack(int damage, float knockback)
    {
        //this.damage = damage;
        this.knockback = knockback;

    }
}
