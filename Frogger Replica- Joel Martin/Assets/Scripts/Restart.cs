using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void LoadIntro()
    {
        Score.CurrentScore = 0;
        Livesdropdown.lives = 1;
        SendText.theName = "";
        Time.timeScale = 1f;
        Car.minSpeed = 8f;
        Car.maxSpeed = 12f;
        SceneManager.LoadScene("Intro");

    }
}
