using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    Vector2 directionX = Vector2.right;
    Vector2 directionY = Vector2.up;
    float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("ball movement.");

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10.0f)
        {
            directionX = -directionX;
            //scoreP1 += 1;
            gameObject.SetActive(false);
        }
        else if (transform.position.x < -10.0f)
        {
            directionX = -directionX;
            //scoreP2 += 1;
            //ScoreText2.text = scoreP2.ToString();
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
}
