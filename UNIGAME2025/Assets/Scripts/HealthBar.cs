using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float maxhealth = 100;
    private float currenthealth;
    [SerializeField] private Image healthBarFill;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Gradient colourGradient;


    void Start()
    {
        currenthealth = maxhealth;
    }

    public void UpdateHealth(float amount)
    {
        currenthealth += amount;
        currenthealth = Mathf.Clamp(currenthealth, 0f, maxhealth);
        healthText.text = "Health: " + currenthealth;
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        float targetFillAmount = currenthealth / maxhealth;
        healthBarFill.fillAmount = targetFillAmount;
        healthBarFill.color = colourGradient.Evaluate(targetFillAmount);

        if (currenthealth <= 0)
        {
            DeathScene();
        }
    }

    void DeathScene()
    {
    SceneManager.LoadScene("LoseScreen");
    }
}
