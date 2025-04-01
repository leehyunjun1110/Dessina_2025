using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public TargetSpawner ts;

    public Transform shootPoint;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ShootRay();
        }
    }

    void ShootRay()
    {
        Ray ray = new Ray(shootPoint.transform.position, shootPoint.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Target"))
            {
                ts.EnQueueTargets(hit.collider.gameObject);
            }
        }
    }
}
