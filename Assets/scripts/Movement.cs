using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        var newXPos = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var newYPos = transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.position = new Vector2(newXPos, newYPos);
    }
}
