using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TapCounter : MonoBehaviour
{
    [SerializeField] TMP_Text _counter;
    [SerializeField] int maxReps;

    private int count;
    

    public void TapCountUp()
    {
        count++;
        if(count == maxReps)
        {
            FinishedSet();
        }
        VisuelCounter();
    }

    private void VisuelCounter()
    {
        _counter.text = count.ToString();
    }

    private void FinishedSet()
    {
        //play Effect
        //playSound
        gameObject.SetActive(false);
    }
}
