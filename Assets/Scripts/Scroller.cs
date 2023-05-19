using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField]
    private Transform[] childs;
    [SerializeField]
    private float scrollSpeed;

    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private Transform endPoint;

    private void Update()
    {
        Scroll();
    }

    private void Scroll()
    {
        // 갖고있는 자식을 모두 한칸씩 밀어줌
        for(int i=0;i<childs.Length; i++)
        {
            childs[i].Translate(Vector2.left * scrollSpeed * Time.deltaTime, Space.World);
            if (childs[i].position.x < endPoint.position.x)
                childs[i].position = startPoint.position;
        }
    }
}
