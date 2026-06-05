using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] LayerMask layerMask;
    [SerializeField] RaycastHit rayCastHit;
    [SerializeField] float distance = 100.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayCastHit, distance, layerMask))
            {
                AudioSource audioSource = rayCastHit.collider.GetComponent<AudioSource>();
                
                if (audioSource.isPlaying == false)
                {
                    audioSource.Play();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        

        Gizmos.DrawRay(ray.origin, ray.direction * 100);
    }
}
