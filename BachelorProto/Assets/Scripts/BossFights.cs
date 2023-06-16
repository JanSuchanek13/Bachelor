using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossFights : MonoBehaviour
{
    [SerializeField] GameObject Image1;
    [SerializeField] GameObject Image2;
    [SerializeField] int maxReps;
    [SerializeField] Timer timer;
    [SerializeField] TMP_Text counter;

    public void StartBoss()
    {
        StartCoroutine("BossFightAnimation");
    }

    private IEnumerator BossFightAnimation()
    {
        for (int i = 0; i < maxReps; i++)
        {
            yield return new WaitForSeconds(3);
            Image2.SetActive(Image1.activeInHierarchy);
            Image1.SetActive(!Image2.activeInHierarchy);
            counter.text = i.ToString();
        }
        timer.FinishTimer();
        gameObject.SetActive(false);
    }
}
