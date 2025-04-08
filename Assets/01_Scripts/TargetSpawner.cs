using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    private Queue<GameObject> targets = new Queue<GameObject>();

    private GameObject nowTarget;
    public void EnQueueTargets(GameObject obj)
    {
        targets.Enqueue(obj);
        obj.SetActive(false);
        Invoke("SeeTargets", 3f);
    }

    private void SeeTargets()
    {
        nowTarget = targets.Dequeue();


        float randomX = Random.Range(-10f, 10f);
        nowTarget.SetActive(true);
        nowTarget.transform.position = new Vector3(randomX, 0, 0);
    }
}
