using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        //        Debug.Log("Collision");
        if(collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiateGameOver();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Laser" || collision.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else
        {
        GameManager.instance.IncreaseScore(10);
        }
        
    }
}
