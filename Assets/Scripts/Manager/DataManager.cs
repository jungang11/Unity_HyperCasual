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
    public event UnityAction<int> OnBestScoreChanged; // ����Ʈ ���ھ �ٲ�� ȣ��

    private int curScore; // ���� ���ھ�
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