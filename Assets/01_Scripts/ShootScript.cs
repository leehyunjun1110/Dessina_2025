using TMPro;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public TargetSpawner ts;

    //public ParticleSystem flashEffect;

    [Header("Magazine")]
    public int magazineCapacity = 30;
    private int currentAmmo;

    public Transform shootPoint;

    public TextMeshProUGUI ammoUi;

    public AudioSource audioSource;
    public AudioClip audioClip;

    private void Start()
    {
        currentAmmo = magazineCapacity;
        //ammoUi.text = currentAmmo + "/" + magazineCapacity;
        ammoUi.text = $"{currentAmmo}/{magazineCapacity}";
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && (currentAmmo > 0))
        {
            currentAmmo--;
            //flashEffect.Play();
            audioSource.PlayOneShot(audioClip);
            ShootRay();
            ammoUi.text = $"{currentAmmo}/{magazineCapacity}";
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
            else if (hit.collider.CompareTag(null))
            {
                Debug.Log("이거때문이네");
            }
        }
    }
}
