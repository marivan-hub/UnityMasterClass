using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    [Header("Характеристики движения")]
    public float speed = 5f;          
    public float amplitude = 2f;      
    public float heightOffset = 0f;   

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {

        float newX = startPosition.x + (speed * Time.time);
        float newY = startPosition.y + heightOffset + Mathf.Sin(Time.time * 3f) * amplitude;
        transform.position = new Vector3(newX, newY, startPosition.z);

        if (newX > 20f) Destroy(gameObject);
    }
}