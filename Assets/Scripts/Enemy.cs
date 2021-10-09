using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;
    float time = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            time += Time.deltaTime;
            if (time > timeToMove && numOfMovements < 14)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                time = 0;
                numOfMovements++;
            }

            if (numOfMovements == 14)
            {
                transform.Translate(new Vector3(0, -0.25f, 0));
                numOfMovements = 0;
                speed = -speed;
                time = 0;
            }

            fireEnemyProjectile();
        }
    }

    void fireEnemyProjectile()
    {
        if (Random.Range(0f, 750f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(transform.position.x, transform.position.y - 0.6f, 0), transform.rotation) as GameObject;
        }
    }
}
