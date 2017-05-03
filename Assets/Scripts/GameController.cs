using System.Collections;
using UnityEngine;


public class GameController : MonoBehaviour
{

    public GameObject Egg;
    public Vector3 spawnValues;
    public int eggCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnEggs());
    }

    IEnumerator SpawnEggs()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < eggCount; i++)
            {
                Vector3 spawnPosition = new Vector3(20, 950, 0);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Egg, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
    
}
