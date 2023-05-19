using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    [SerializeField] private State curState;

    public UnityEvent OnReadyed; // 준비 완료됐을 때 이벤트
    public UnityEvent OnPlayed;
    public UnityEvent OnGameOvered;

    // 처음 상황이 Ready기 때문에 Start에서 Ready
    private void Start()
    {
        Ready();
        GameManager.Data.CurScore = 0;
    }

    // 이벤트는 아무것도 안붙어있을 때 조심해야하기 때문에 ? 사용
    public void Ready()
    {
        curState = State.Ready;
        OnReadyed?.Invoke();
    }

    public void Play()
    {
        curState = State.Play;
        OnPlayed?.Invoke();
    }

    public void GameOver()
    {
        curState = State.GameOver;
        OnGameOvered?.Invoke();
    }

    public enum State
    {
        Ready,    // 준비
        Play,     // 진행중
        GameOver, // 게임오버
    }
}
