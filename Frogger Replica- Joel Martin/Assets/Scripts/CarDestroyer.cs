using UnityEngine;

public class CarDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Car")
            Destroy(other.gameObject);
    }
}
