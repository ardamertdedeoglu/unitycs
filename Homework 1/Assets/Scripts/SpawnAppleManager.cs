using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class SpawnAppleManager : MonoBehaviour
{
    public GameObject applePrefab;
    public static SpawnAppleManager instance;
    public int score;
    public TMP_Text scoreText;

    private void Awake()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<TMP_Text>();
        score = 0;
        instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnApple();
        }

    }

    // public void MetotIsmi
    // private void MetotIsmi
    public void SpawnApple()
    {
        Instantiate(applePrefab, gameObject.transform.position, Quaternion.identity);
    }

    public void UpdateScore()
    {
        score++;
        scoreText.SetText("Score: " + score.ToString());
    }
}