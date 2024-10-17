using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    Vector3 orginalPosition;
    Vector2 directionX = Vector2.right;
    Vector2 directionY = Vector2.up;
    float speed = 8.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Game Start.");
        orginalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 12.0f || transform.position.x < -12.0f)
        {
            //directionX = -directionX;

            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.transform.position = orginalPosition;
            RandomDirection();
            gameObject.GetComponent<Renderer>().enabled = true;
        }

        if (transform.position.y > 5.0f || transform.position.y < -5.0f)
        {
            directionY = -directionY;
        }
        float dt = Time.deltaTime;
        Vector3 changeX = directionX * speed * dt;
        Vector3 changeY = directionY * speed * dt;
        transform.position = transform.position + changeX + changeY;
    }

    void RandomDirection()
    {

    }
    public void ChangeDirection()
    {
        directionY = -directionY;
        directionX = -directionX;
        Debug.Log("change direction");
    }
}
