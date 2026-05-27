using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
   
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // Time.deltaTime
        // 이전 프레임에서 현재 프레임까지 걸린 시간입니다.

        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime; 
    }
}
