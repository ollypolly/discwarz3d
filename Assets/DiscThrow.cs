using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscThrow : MonoBehaviour
{

    public Vector2 moveSpeed;

    Collider2D col;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + new Vector3(moveSpeed.x, moveSpeed.y) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        switch (collision.tag)
        {
            case "TopWall":
                moveSpeed.y = -moveSpeed.y;
                break;
            case "BottomWall":
                moveSpeed.y = -moveSpeed.y;
                break;
            case "RightWall":
                moveSpeed.x = -moveSpeed.x;
                break;
            case "LeftWall":
                moveSpeed.x = -moveSpeed.x;
                break;
            default:
                break;
        }
 
    }
}
