using UnityEngine;

public class KotakManager : MonoBehaviour
{
    public float spawnTime;
    public Transform[] spawnPoints;

    [SerializeField]
    KotakSpawner factory;
    IFactory Factory { get { return factory as IFactory; } }

    void Start(){
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn(){
        //Jika player telah mati maka tidak membuat kotak baru
        /*if (playerHealth.currentHealth <= 0f){
           return;
        }*/

        //Mendapatkan nilai random
       int spawnPointIndex = Random.Range(0, spawnPoints.Length);
       int spawnKotak = Random.Range(0, 3);

        //Memduplikasi kotak
        Factory.FactoryMethod(spawnKotak, spawnPoints[spawnPointIndex]);
    }
}