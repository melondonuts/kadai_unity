using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{


    public GameObject[] tilePrefabs;

    Transform playerTransform;
    float spawnZ = 0f;
    float tileLength = 90f;
    float SafeZone = 15f;

    public GameObject player;

    private int amnTilesOnScreen = 4;
    private int lastPrefabIndex = 0;

    List<GameObject> activeTiles;



    // Start is called before the first frame update
    void Start()
    {
        activeTiles = new List<GameObject>();

        playerTransform = player.transform;
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            if (i < 2)
            
                SpawnTile(0);
            else
                SpawnTile();



            SpawnTile();
        }
    }

    void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
    #endif
    }

    void Update()
    {
        if (playerTransform.position.z - SafeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
            deleteTile();

        }
        if (Input.GetKey(KeyCode.Escape)) Quit();


    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;

        if (prefabIndex == -1)
            go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;
            //go = Instantiate(tilePrefabs [RandomPrefabIndex()]) as GameObject;
            go.transform.SetParent(transform ) ;
            go.transform.position = Vector3.forward * spawnZ;
            spawnZ += tileLength;
            activeTiles.Add(go);

    }

    void deleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length<= 1)
        {
            return 0;
        }

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex ;
        
    }


}

