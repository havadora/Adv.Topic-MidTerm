using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int height;
    public int weight;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObj()
    {
        int randomX = Random.Range(-weight, weight);
        int randonY = Random.Range(-height, height);
        Instantiate(target, new Vector3(randomX + 0.5f, randonY + 0.5f, 0f), Quaternion.identity);
    }
    
}
