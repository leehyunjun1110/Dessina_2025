using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField]
    private int speed = 3;

    void Update()
    {
        switch (Input.inputString)
        {
            case "W":
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                break;
            case "A":
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                break;
            case "S":
                transform.Translate(Vector3.back * speed * Time.deltaTime);
                break;
            case "D":
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                break;
            default:
                break;
        }
    }
}
