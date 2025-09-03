using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Slider healthSlider;

    private void OnEnable()
    {
        GameManager.OnScoreChanged += UpdateScore;
        GameManager.OnHealthChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        GameManager.OnScoreChanged -= UpdateScore;
        GameManager.OnHealthChanged -= UpdateHealth;
    }

    private void Start()
    {
        UpdateScore (0);
        UpdateHealth(100);
    }

    private void UpdateScore(int noviScore)
    {
        if (scoreText != null) 
        scoreText.text ="Score: " + noviScore;
    }
    private void UpdateHealth(int noviHealth)
    {
        if (healthSlider != null) 
        healthSlider.value = noviHealth; 
    }
}
