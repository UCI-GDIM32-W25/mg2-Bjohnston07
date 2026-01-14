using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject coinPrefab;
    public Transform coinSpawn;

    private bool doTimer;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Points: 0";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Debug.Log("Coin Spawned");
            Instantiate(coinPrefab, coinSpawn.position, coinSpawn.rotation);
            timer = getRandomTime();
        }
    }

    public void updatePointsText(int points)
    {
        text.text = "Points: " + points;
    }

    public float getRandomTime()
    {
        return Random.Range(1, 3);
        
    }
}
