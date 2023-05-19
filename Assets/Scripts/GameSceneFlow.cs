using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    [SerializeField] private State curState;

    public UnityEvent OnReadyed; // �غ� �Ϸ���� �� �̺�Ʈ
    public UnityEvent OnPlayed;
    public UnityEvent OnGameOvered;

    // ó�� ��Ȳ�� Ready�� ������ Start���� Ready
    private void Start()
    {
        Ready();
        GameManager.Data.CurScore = 0;
    }

    // �̺�Ʈ�� �ƹ��͵� �Ⱥپ����� �� �����ؾ��ϱ� ������ ? ���
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
        Ready,    // �غ�
        Play,     // ������
        GameOver, // ���ӿ���
    }
}
