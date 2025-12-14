using UnityEngine;

public class FastDuck : Duck
{
    public float fast_duck_speed = 12f;

    void Start()
    {
        GetComponent<DuckMovement>().speed = fast_duck_speed;
        maxHealth = 1;
        base.Start();
    }

    protected override void Die()
    {
        Debug.Log("Быстрая утка погибла!");
        base.Die();
    }
}