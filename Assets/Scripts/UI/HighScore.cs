
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    public Transform player;

    private bool oneTime = true;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing = true;
    public long multValue = 50000;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("highScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount = GameObject.Find("Player").GetComponent<UI>().kmUp;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("highScore", highScoreCount);
        }
        float hgsc = Mathf.Round(highScoreCount);
        string highScoreString = hgsc.ToString("n0");
        highScoreText.text = "High Score: \n" + highScoreString + " KM"; 

        if (scoreCount >= 300)
        {
            if (oneTime == true)
            {

               
                oneTime = false;
            }

        }

    }

    public void AddScore(int pointsScored)
    {
        scoreCount += pointsScored;
    }
}
