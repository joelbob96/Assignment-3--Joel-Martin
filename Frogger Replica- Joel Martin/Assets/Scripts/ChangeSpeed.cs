using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public void setSpeed(float newSpeed)
    {
        Car.minSpeed = newSpeed;
        Car.maxSpeed = newSpeed + 4f;
    }
}
