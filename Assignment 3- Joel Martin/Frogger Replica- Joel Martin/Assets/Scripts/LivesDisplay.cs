using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public Text LivesText;

    void Start()
    {
        LivesText.text = "Lives: " + Livesdropdown.lives.ToString();
    }
}
