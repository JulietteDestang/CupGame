using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject BallPrefab;
    [SerializeField] private Material[] randomMaterials;
    private float xRange = 8f;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("ball").Length == 0 && (Time.timeSinceLevelLoad <= 120))
        {
            SpawnBallAtRandom();
        }
    }

    void SpawnBallAtRandom()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = 5f;

        var randomPosition = new Vector3(xPosition, yPosition, 1f);

        Instantiate(BallPrefab, randomPosition, Quaternion.identity);
        BallPrefab.GetComponent<Renderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)];
    }
}
