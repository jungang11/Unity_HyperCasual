using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    [SerializeField] 
    private float spawnDelay;
    [SerializeField] 
    private PipeLine pipeLinePrefab;
    [SerializeField]
    private float randomRange;

    Coroutine spawnRoutine;

    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopCoroutine(spawnRoutine);
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Vector3 spawnPos = transform.position + Vector3.up * Random.Range(-randomRange, randomRange);
            Instantiate(pipeLinePrefab, spawnPos, transform.rotation);
        }
    }
}
