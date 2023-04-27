using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] myObjects;

    private IEnumerator SpawnItem()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(0, 5, 0);
            GameObject obj = Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            obj.transform.localScale *= 0.6f;
        }
    }

    private void Start()
    {
        Debug.Log(myObjects.Length);
        StartCoroutine(SpawnItem());
    }
}
