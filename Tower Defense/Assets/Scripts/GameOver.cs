using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI roundsText;
    private void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        Debug.Log("Go to menu.");
    }
}
