using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private float score = 0.0f;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;
    private bool isDead = false;
    
   public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead) return;

        if (score >= scoreToNextLevel)
        {
            levelUp();
        }

        score += Time.deltaTime * difficultyLevel;
        scoreText.text = ((int)score).ToString();
	}

    void levelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;
        scoreToNextLevel *= 2;
        difficultyLevel++;

        GetComponent<PlayerMovement>().setSpeed(difficultyLevel);

        Debug.Log(difficultyLevel);
    }

    public void onDeath()
    {
        isDead = true;
    }
}
