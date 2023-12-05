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
    public GameObject PistolObject;
    public GameObject ARObject;
    public int score;
    public int streak;
    private int HighestStreak;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI StreakText;
    public TextMeshProUGUI HighStreakText;
    public TextMeshProUGUI WeaponText;
    public DetectCollisions CollisionScript;

    public GameObject TargetObject;
    public bool playing;
    


    void Start()
    {
        CollisionScript = TargetObject.GetComponent<DetectCollisions>();
        Cursor.visible = false;
        Score(0);
        score = 0;
        streak = 0;
        HighestStreak = 0;
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
            playing = false;
            Time.timeScale = 0;
        }
        WeaponSelect();
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
        playing = true;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Score(int scoreToAdd)
    {
        score += scoreToAdd;
        ScoreText.text = "Score: " + score;
    }

    public void UpdateStreak(int StreakCount)
    {
        streak += StreakCount;
        StreakText.text = "Current Streak: " + streak;
        if (HighestStreak < streak)
        {
            HighestStreak = streak;
        }
        HighStreakText.text = "Highest Streak: " + HighestStreak;
    }

    public void WeaponSelect()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PistolObject.SetActive(true);
            ARObject.SetActive(false);
            WeaponText.text = "Pistol";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PistolObject.SetActive(false);
            ARObject.SetActive(true);
            WeaponText.text = "AR";
        }
    }
}
