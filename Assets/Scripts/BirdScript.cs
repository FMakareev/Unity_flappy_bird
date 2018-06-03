using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // 
    public Vector2 jumpForce = new Vector2();

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector2(-2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Expectations for clicking with a mouse
        if (Input.GetButtonDown("Fire1"))
        {
            // Set the speed of the rigid body of the bird to zero
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            // Adding a jump power to the rigid body of a bird
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }

        // Get the real position of the bird on the stage in pixels
        Vector2 stagePosition = Camera.main.WorldToScreenPoint(transform.position);
        // If the bird leaves the scene ...
        if (stagePosition.y > Screen.height || stagePosition.y < 0)
        {
            Die();
        }
    }
    // The function is called if the bird encounters something
    private void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    private void Die()
    {
        Debug.Log("GameOver!");
        Application.LoadLevel("GameOver");
    }
}