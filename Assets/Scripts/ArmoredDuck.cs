using UnityEngine;

public class ArmoredDuck : Duck
{
    [Header("Характеристики")]
    [SerializeField] private int armour = 2;

    void Start()
    {
        GetComponent<DuckMovement>().speed = 4f;
        maxHealth = 5;
        currentHealth = maxHealth;
        base.Start();
    }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = damage / armour;
        base.TakeDamage(reducedDamage);
    }
}