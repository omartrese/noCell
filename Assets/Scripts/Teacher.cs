using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    private int currentTargetIndex = 0;
    [SerializeField]
    private float speed;
    public Player playerScript;
    public GameObject[] targets;
    

    void Update()
    {
        if(playerScript.gameEnd) { return; }

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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "playerZone")
        {
            if (playerScript.usingCell)
            {
                Debug.LogWarning("el hijo de puta de tu alumno retrasado está usando el movil, quitaselo");
                playerScript.usingCell = false;
                playerScript.gameEnd = true;
                return;
            }
            Debug.LogWarning("Has pasado por la zona del alumno. Que buen profe (mentira)");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "playerZone")
        {
            if (playerScript.usingCell)
            {
                Debug.LogWarning("el hijo de puta de tu alumno retrasado está usando el movil, quitaselo");
                playerScript.usingCell = false;
                playerScript.gameEnd = true;
                return;
            }
            Debug.LogWarning("Has pasado por la zona del alumno. Que buen profe (mentira)");
        }
    }
}