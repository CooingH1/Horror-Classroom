using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AI : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotationSpeed = 3f;
    public float damageAmount = 10f;
    public Transform target;

    void Update()
    {
        // Rotate towards target
        Vector3 targetDir = target.position - transform.position;
        float step = rotationSpeed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);

        // Move towards target
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }

}
