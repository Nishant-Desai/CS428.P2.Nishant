using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiptSpawn : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject G;
    public bool isSpawned;
    private GameObject newObject;
    // Start is called before the first frame update
    void Start()
    {
        isSpawned=false;
    }

    // Update is called once per frame
    public void SpawnReceipt()
    {
        if(!isSpawned)
        {
            isSpawned=true;
            Instantiate(G, Spawnpoint.position, Quaternion.Euler(0,0,0));
            isSpawned=false;
        }
    }
}
