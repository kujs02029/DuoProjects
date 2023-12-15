using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] GameObject panel;

    public void add(int scoretoAdd)
    {
        score += scoretoAdd;
        txt.text = score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        panel.SetActive(true);
    }
}
