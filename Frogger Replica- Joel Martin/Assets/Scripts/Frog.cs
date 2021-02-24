using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Car")
        {
            Debug.Log("We lost");
            //Score.CurrentScore = 0;
            Livesdropdown.lives -= 1;
            if (Livesdropdown.lives < 1)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }else if(col.tag == "Barrier Bottom")
        {
            rb.MovePosition(rb.position + Vector2.up);
        }else if(col.tag == "Barrier Left")
        {
            rb.MovePosition(rb.position + Vector2.right);
        }else if(col.tag == "Barrier Right")
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
    }
}
