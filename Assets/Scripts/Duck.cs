using UnityEngine;

public class Duck : MonoBehaviour
{
    [Header("Характеристики")]
    [SerializeField] protected int maxHealth = 5;
    protected int currentHealth;

    [Header("Очки")]
    [SerializeField] protected float score = 0.5f;

    protected void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("123312");
    }


    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
        Debug.Log($"{gameObject.name} получила урон: {damage}. Осталось HP: {currentHealth}");
    }
    public void Heal(int heal_point)
    {
        currentHealth += heal_point;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }

    }
    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}