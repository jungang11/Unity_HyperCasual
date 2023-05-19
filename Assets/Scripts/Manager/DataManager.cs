using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    private int bestScore;
    public int BestScore 
    { 
        get { return bestScore; } 
        set
        {
            if(bestScore != value)
            {
                OnBestScoreChanged?.Invoke(value);
                bestScore = value;
            }
        }
    }
    public event UnityAction<int> OnBestScoreChanged; // 베스트 스코어가 바뀌면 호출

    private int curScore; // 현재 스코어
    public int CurScore
    {
        get { return curScore; }
        set
        {
            OnCurScoreChanged?.Invoke(value);
            curScore = value;

            if (curScore > BestScore)
            {
                BestScore = curScore;
            }
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}