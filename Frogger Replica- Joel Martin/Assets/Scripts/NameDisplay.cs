using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    public Text PlayerName;
    public void Start()
    {
        PlayerName.text = "Player: " + SendText.theName;
    }
}
