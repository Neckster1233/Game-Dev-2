using UnityEngine;

public class RotateAtEnemy : MonoBehaviour
{
    public Vector3Data enemy;
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 Direction = (enemy.value - transform.position).normalized;
        
        Quaternion lookRotation = Quaternion.LookRotation(Direction);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
    }
}