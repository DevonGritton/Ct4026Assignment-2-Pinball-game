using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] SFX;
    public GameObject powerUp;
    public Transform dropPoint;
    // Start is called before the first frame update
    void Start()
    {
       // if (SFX.Length <= 0)
       // {
          //  SpawnEffect();
       // }
    }
    IEnumerator PowerUpDrop()
    {
       
            SpawnEffect();
            yield return new WaitForSeconds(1);
        
    }
    void SpawnEffect()
    {
        GameObject Spawn = Instantiate(powerUp, dropPoint.position, dropPoint.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        SFX = GameObject.FindGameObjectsWithTag("Effect");
        if (SFX.Length > 1)
        {
            return;
        }
        else
        {
            StartCoroutine("PowerUpDrop");

        }
           
    }
}
