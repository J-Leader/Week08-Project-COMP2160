using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;
    static public ScoreKeeper Instance 
    {
        get 
        {
            if (instance == null)
            {
                Debug.LogError("There is no ScoreKeeper instance in the scene.");
            }
            return instance;
        }
    }

    private int score = 0;
    public int Score
    {
        get
        {
            return score;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Player.Instance.OnPickupEvent += OnScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnScore(int points)
    {
        score += points;
    }
}
