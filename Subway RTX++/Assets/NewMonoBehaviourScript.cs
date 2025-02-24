using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveToLimits : MonoBehaviour
{
    public float speed = 2.0f; // Adjust the speed of movement
    private bool isMoving = false;
    private float leftLimit = -2.0f;
    private float rightLimit = 2.0f;
    private float center = 0.0f;

    void Update()
    {
        // Move based on 'A' key press
        if (Input.GetKeyDown(KeyCode.A) && !isMoving)
        {
            if (transform.position.x == center)
            {
                StartCoroutine(MoveToX(leftLimit));
            }
            else if (transform.position.x == rightLimit)
            {
                StartCoroutine(MoveToX(center));
            }
        }
    }

    IEnumerator MoveToX(float targetX)
    {
        isMoving = true;
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

        while (transform.position.x != targetX)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            yield return null;
        }

        isMoving = false;
    }
}