using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;
    public GameObject[] prefabs; 
    public AudioSource audioSource;
    public AudioClip coinClip;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 2,2);
    }

    public void SpawnObjects()
    {
        //audioSource.Play();
        //audioSource.clip = coinClip;
        //audioSource.PlayOneShot(coinClip);

        float xPos = Random.Range(leftPoint.position.x, rightPoint.position.x);
        float yPos = leftPoint.position.y;
        Vector3 RandomCoinPosition = new Vector3(xPos, yPos,0);
        int indexPrefab = Random.Range(0, 3);
        Instantiate(prefabs[indexPrefab], RandomCoinPosition, Quaternion.identity);

    }

}
