using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject basicEnemyPrefab;
    public float spawnDelay;
    public static int spawnPosCount = 5;
    public Vector2[] spawnPositions = new Vector2[spawnPosCount];

    private int spawnIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (gameObject.activeSelf)
        {
            spawnIndex = Random.Range(0, spawnPosCount - 1);
            yield return new WaitForSeconds(spawnDelay);
            GameObject enemy = Instantiate(basicEnemyPrefab, spawnPositions[spawnIndex], gameObject.transform.rotation);
        }
    }
}
