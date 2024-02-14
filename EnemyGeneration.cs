using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyGeneration : MonoBehaviour
{
    [SerializeField] private GameObject[] ArrayOfEnemies;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int numOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (numOfEnemies < 10)
        {
            GenerateEnemies();
        }
    }

    void GenerateEnemies()
    {   
        Vector3 randomPosition = new Vector3(Random.Range(-260, 215), Random.Range(300, 200), 0);
        int randomIndex = Random.Range(0, ArrayOfEnemies.Length);
        Instantiate(ArrayOfEnemies[randomIndex], randomPosition, Quaternion.identity);
    }
}
