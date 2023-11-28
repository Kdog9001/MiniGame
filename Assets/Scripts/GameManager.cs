using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject QuitButton;
    public GameObject ResumeButton;
    public GameObject Title;
    public GameObject RestartButton;
    void Start()
    {
        Cursor.visible = false;
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
}
