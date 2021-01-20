using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;

    public GameObject scoreText;
    public static GameManager GMinstance;
    // Start is called before the first frame update
    void Start()
    {
        if(GMinstance == null)
        {
            GMinstance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Addscore()
    {
        score++;
        scoreText.GetComponent<Text>().text = "Score : " + score;
    }
}
