using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            var screenCenter = new Vector3(Screen.width * 0.85f, Screen.height / 2);
            var screenWorldCenter = Camera.main.ScreenToWorldPoint(screenCenter);
            screenWorldCenter.z = collision.gameObject.transform.position.z;
            collision.gameObject.transform.position = screenWorldCenter;


            Destroy(enemyProjectile);

            GameManager.stopGame();
        }

        if(collision.gameObject.tag == "Edge")
        {
            Destroy(enemyProjectile);
        }
    }
}
