using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text visuelTimer;
    [SerializeField] TMP_Text visuelBestTime;
    public bool countTime;


    private float currentTime;
    private float bestTime = 1000f;

    private void Start()
    {
        UpdateBestTime();
    }

    private void Update()
    {
        if (countTime)
        {
            Counter();
        }
        
    }

    public void EnableTimer()
    {
        countTime = true;
    }

    private void Counter()
    {
        currentTime += Time.deltaTime;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        visuelTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void UpdateBestTime()
    {
        float minutes = Mathf.FloorToInt(bestTime / 60);
        float seconds = Mathf.FloorToInt(bestTime % 60);
        visuelBestTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    public void FinishTimer()
    {
        countTime = false;
        if(currentTime < bestTime)
        {
            bestTime = currentTime;
            UpdateBestTime();
        }
    }
}
