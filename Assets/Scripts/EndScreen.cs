using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    //Quiz quiz;
    //[SerializeField] GameObject quizCanvas;
    //[SerializeField] GameObject endScreenCanvas;
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    void Awake()
    {
        //quiz = FindObjectOfType<Quiz>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (quiz.isComplete)
    //    {
            
    //        Destroy(quizCanvas);
    //        endScreenCanvas.SetActive(true);
    //        scoreText.text = "Your score is: "+scoreKeeper.CalculateScore() + "%";
    //    }
    //}
    public void ShowScore()
    {
        scoreText.text = "Your score is: " + scoreKeeper.CalculateScore() + "%";
    }
    //public void OnRestart()
    //{
    //    SceneManager.LoadScene(0);
    //}
}
