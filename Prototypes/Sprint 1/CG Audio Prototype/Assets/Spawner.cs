using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;
   
    void Start()
    {
        
    }

    
    
    public void RandomPos()
    {
        float randPosX = Random.Range(-2.0f, 2.0f);
        float randPosY = Random.Range(3.0f, 10.0f);
        float randPosZ = Random.Range(-2.0f, 2.0f);
        Vector3 pos = new Vector3(randPosX, randPosY, randPosZ);
        Instantiate(cubePrefab, pos, Quaternion.identity);
    }
}
