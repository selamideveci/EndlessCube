using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject engel;
    public Transform spawnPoint;
    int Score=0;

    public TextMeshProUGUI score;
    public GameObject play;
    public GameObject player;

    
    void Update()
    {
        
    }

    IEnumerator spawnEngel()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(engel, spawnPoint.position, Quaternion.identity);
        }
    }

    void scoreUp()
    {
        Score++;
        score.text = Score.ToString();
        
    }

    public void GameStart()
    {
        player.SetActive(true);
        play.SetActive(false);
        StartCoroutine(spawnEngel());
        InvokeRepeating("scoreUp",2f,1f);
    }
}
