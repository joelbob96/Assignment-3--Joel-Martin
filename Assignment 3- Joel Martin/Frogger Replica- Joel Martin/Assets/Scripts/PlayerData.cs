using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int Score;
    public int Lives;
    public string Name;
    public float MinSpeed;
    public float MaxSpeed;

    //public float[] position;
    //public GameObject Frog;

    public PlayerData(Player player)
    {
        Score = player.score;
        Lives = player.lives;
        Name = player.name;
        MinSpeed = player.min;
        MaxSpeed = player.max;

        //position = new float[2];
        //position[0] = Frog.transform.position.x;
        //position[1] = Frog.transform.position.y;
        //position[2] = Player.transform.position.z;
    }
}
