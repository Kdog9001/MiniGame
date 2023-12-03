using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject QuitButton;
    public GameObject ResumeButton;
    public GameObject Title;
    public GameObject RestartButton;
    public int score;
    public TextMeshProUGUI ScoreText;


    void Start()
    {
        Cursor.visible = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.visible = true;
            QuitButton.SetActive(true);
            ResumeButton.SetActive(true);
            Title.SetActive(true);
            RestartButton.SetActive(true);
        }
        Score();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        Cursor.visible = false;
        QuitButton.SetActive(false);
        ResumeButton.SetActive(false);
        Title.SetActive(false);
        RestartButton.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Score()
    {
        //score += 1;
        ScoreText.text = "Score: " + score;
    }
}
