using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
    //public GameObject items;

    public GameObject[] myObjects;
    // Start is called before the first frame update
    void Start()
    {
        //innerItemsArray = items.GetComponentsInChildren<GameObject>();
        //SpawnRandomInnerItem();
        Debug.Log(myObjects.Length);
        StartCoroutine(spwan_item());
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space)){
        //     int randomIndex = Random.Range(0,myObjects.Length);
        //     Vector3 randomSpawnPosition = new Vector3(-5,5,0);
        //     Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        // }
    }

    private IEnumerator spwan_item(){
        while (true)
        {
            yield return new WaitForSeconds(2);
            int randomIndex = Random.Range(0,myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(0,5,0);
            GameObject obj = Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            obj.transform.localScale *= 0.6f;
        }
    }
}
