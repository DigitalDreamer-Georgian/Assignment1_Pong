using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PongManager : MonoBehaviour
{
    int scoreP1 = 0;
    int scoreP2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player1 Score:" + scoreP1);
        Debug.Log("Player1 Score:" + scoreP2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
