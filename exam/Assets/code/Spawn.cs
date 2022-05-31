using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public int numberTs;

    public List<GameObject> spawnpool;

    public GameObject quad;
 
    void Start()
    {
        SpawnObj();
    }

    public void SpawnObj()
    {

        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c  = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for(int i = 0; i < numberTs; i++)
        {
            randomItem = Random.Range(0, spawnpool.Count);
            toSpawn = spawnpool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.x, c.bounds.max.x);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
    

    void Update()
    {
        
    }
}
