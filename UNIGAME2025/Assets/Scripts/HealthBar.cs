using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBarFill;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Gradient colourGradient;
    [SerializeField] private Health playerHealth;

    private void Start()
    {
        UpdateUI();
    }

    private void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        float fill = playerHealth.CurrentHealth / playerHealth.maxHealth;
        healthBarFill.fillAmount = fill;
        healthBarFill.color = colourGradient.Evaluate(fill);
        healthText.text = "Health: " + playerHealth.CurrentHealth;
    }
}