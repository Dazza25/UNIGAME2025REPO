using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float CurrentHealth { get; private set; }

    void Start()
    {
        CurrentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - amount, 0, maxHealth);

        if (CurrentHealth <= 0)
            SceneManager.LoadScene("LoseScreen");
    }

    public void Heal(float amount)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, maxHealth);
    }
}