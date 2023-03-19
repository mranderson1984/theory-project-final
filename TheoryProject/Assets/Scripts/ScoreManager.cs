using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get; private set;}
    
    [SerializeField]
    private int score;
    public int Score
    {
        get { return score; }
        set
        {
            if(score < 0)
            {
                Debug.Log("Score cannot be set to a negative number");
                return;
            }
            score = value;
        }
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

}
