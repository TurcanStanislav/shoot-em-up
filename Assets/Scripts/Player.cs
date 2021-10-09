using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject projectile;
    public readonly int maxProjectile = 5;
    public static int projectileCounter = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.playGame) movement();
        fireProjectile();
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }
    }

    void fireProjectile()
    {

        if(Input.GetKeyDown(KeyCode.Space) && projectileCounter < maxProjectile)
        {
            var _ = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + 0.6f, 0), transform.rotation) as GameObject;
            projectileCounter++;
        }
    }
}
