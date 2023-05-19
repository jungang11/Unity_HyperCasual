using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLine : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        Destroy(gameObject, 5);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
