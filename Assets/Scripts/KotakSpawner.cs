using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KotakSpawner : MonoBehaviour, IFactory
{
    [SerializeField]
    GameObject[] KotakPrefab;

    public GameObject FactoryMethod(int tag, Transform spawnPoint)
    {
        GameObject enemy = Instantiate(KotakPrefab[tag],spawnPoint);
        return enemy;
    }
}