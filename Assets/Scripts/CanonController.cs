using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    
    
    public GameObject bullet;
    public float bulletSpeed;
    public float frequence;
    public Transform SpawnPoint;



    void Start()
    {
        StartCoroutine("timer"); 
    }

    IEnumerator timer()
    {
        while(true)
        {
            //заспавнить шар
            Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(frequence);
        }
    }
}
