using UnityEngine;
using UnityEngine.UI;

public class Livesdropdown : MonoBehaviour
{
    public static int lives = 1;
    public Dropdown noSelected;

    void Update()
    {
        switch (noSelected.value) {
            case 0:
                lives = 1;
                break;
            case 1:
                lives = 5;
                break;
            case 2:
                lives = 10;
                break;
            default:
                lives = 1;
                break;

                }
    }
}
