using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float leftBounds = 21.0f;

    public float rightBounds = -10.0f;

    void Awake()
    {
       Time.timeScale = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBounds)
        {
            // Debug.Log("Game Over");
            Destroy(gameObject);
            // Time.timeScale = 0;
        }
    }
}
