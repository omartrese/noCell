using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public GameObject[] targets;
    private int currentTargetIndex = 0;

    void Update()
    {
        if (currentTargetIndex < targets.Length)
        {
            GameObject currentTarget = targets[currentTargetIndex];
            Vector3 targetPosition = currentTarget.transform.position;

            Vector3 direction = new Vector3(targetPosition.x - transform.position.x, 0, targetPosition.z - transform.position.z);
            direction.Normalize();

            transform.Translate(direction * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 3f)
            {
                //if(currentTargetIndex >= 3)
                //{
                //    currentTargetIndex = 0;
                //} else currentTargetIndex++;
                currentTargetIndex++;
            }
        } else currentTargetIndex = 0;
    }
}