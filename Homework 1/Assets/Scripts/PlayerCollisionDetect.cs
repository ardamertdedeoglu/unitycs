using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollisionDetect : MonoBehaviour
{
    public TMP_Text scoreText;
    public SpawnAppleManager spawnAppleManager;
    private void Awake()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<TMP_Text>();
        spawnAppleManager = GameObject.Find("Apple Spawner").GetComponent<SpawnAppleManager>();
    }
    
    public int score;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            spawnAppleManager.UpdateScore();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
