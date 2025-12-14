using UnityEngine;

public class BossDuck : Duck
{
    void Start()
    {
        GetComponent<DuckMovement>().speed = 2f;
        maxHealth = 20;
        currentHealth = maxHealth;
        transform.localScale = Vector3.one * 2f;
        base.Start();
    }

    protected override void Die()
    {
        Debug.Log("аняя срнвйю онаефдEмю!");
        base.Die();
    }
}