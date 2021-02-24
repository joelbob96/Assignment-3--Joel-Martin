using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int score; 
    public int lives;
    public string name;
    public float min;
    public float max;

    public void Update()
    {
        score = Score.CurrentScore;
        lives = Livesdropdown.lives;
        name = SendText.theName;
    }

    public void Start()
    {
        min = Car.minSpeed;
        max = Car.maxSpeed;
    }

    public void SavePlayer()
    {
        Save.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = Save.LoadPlayer();
        Score.CurrentScore = data.Score;
        Livesdropdown.lives = data.Lives;
        SendText.theName = data.Name;
        Car.minSpeed = data.MinSpeed;
        Car.maxSpeed = data.MaxSpeed;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}
