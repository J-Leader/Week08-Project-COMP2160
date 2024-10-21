using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    static private UiManager instance;
    static public UiManager Instance 
    {
        get 
        {
            if (instance == null) 
            {
                Debug.LogError("There is not UiManager in the scene.");
            }            
            return instance;
        }
    }


    [SerializeField] private string scoreFormat = "Score: {0}";
    [SerializeField] private Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = string.Format(scoreFormat, GameManager.Instance.Score); 
    }
}
