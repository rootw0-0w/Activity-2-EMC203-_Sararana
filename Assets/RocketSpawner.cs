using UnityEngine;
using System.Collections;

public class RocketSpawner : MonoBehaviour
{
    public Transform PlayerObject;
    public GameObject rocketPrefab;
    public GameObject powerupGameObject;
    public float collection_zone = 2f;
    public int rocketCount = 5;
    public float speed = 4f;

    void Update()
    {
        if (powerupGameObject == null) return; //detects if object is there

        Vector3 distance = PlayerObject.position - powerupGameObject.transform.position;
        float Range_Zone = distance.magnitude;
       
        //if near triggers powerup
       if (Range_Zone <= collection_zone)
        {
            rocketCount++;

                Destroy(powerupGameObject);

                    return;  
        }
    }

    void Start()
    {
        StartCoroutine(SpawnRockets());
    }

    IEnumerator SpawnRockets()
    {
        while (true) // Loop forever
        {
            float rocketSpacing = 360f / rocketCount;

            for (int i = 0; i < rocketCount; i++)
            {
                float targetAngle = (i * rocketSpacing) + 45f;
                Quaternion spawnRotation = Quaternion.Euler(0, 0, targetAngle);

                GameObject rocket = Instantiate(rocketPrefab, transform.position, spawnRotation);

                    Destroy(rocket, 5f);// destroys at every 5 seconds
            }

            // Pause for 3 seconds 
            yield return new WaitForSeconds(3f);
        }
    }

}
