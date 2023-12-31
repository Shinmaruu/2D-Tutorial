using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float yPosition;
    [SerializeField] GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //        Debug.Log(Input.mousePosition);
        Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(convertedPosition.x, yPosition, 0);

        if (Input.GetButtonDown("Fire Laser")){
            Instantiate(laser, transform.position + new Vector3(0, .5f, 0), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //        Debug.Log("Collision");
        if (collision.gameObject.tag == "PowerUp")
        {
            Destroy(collision.gameObject);

        }
        

    }
}
