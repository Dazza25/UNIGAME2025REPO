using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float damage = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}