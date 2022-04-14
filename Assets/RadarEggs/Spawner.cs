using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject eggPrefab;
    [SerializeField] private GameObject medPrefab;
    [SerializeField] private Terrain terrain;
    private TerrainData terrainData;

    // Start is called before the first frame update
    void Start()
    {
        terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg", 1, 5f);
        InvokeRepeating("CreateMedKit", 1, 5f);
    }

    void CreateEgg()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;

        GameObject egg = Instantiate(eggPrefab, pos, Quaternion.identity);
    }

    void CreateMedKit()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;

        GameObject egg = Instantiate(medPrefab, pos, Quaternion.identity);
    }
}
