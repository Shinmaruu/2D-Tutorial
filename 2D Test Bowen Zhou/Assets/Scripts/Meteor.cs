using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] GameManager manager;
    [SerializeField] GameObject powerUpPrefab;
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
        Vector3 currentPos = transform.position;
        float xCoord = currentPos.x;
        float yCoord = currentPos.y;
        float zCoord = currentPos.z;
        if (collision.gameObject.tag == "Laser")
        {
            Instantiate(powerUpPrefab, new Vector3(xCoord, yCoord, zCoord), Quaternion.identity);
        }

        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
