using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerController1 playerController1Script;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerController1Script = GameObject.Find("Player").GetComponent<PlayerController1>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController1Script.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); 
        }   
        if(transform.position.x< leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
