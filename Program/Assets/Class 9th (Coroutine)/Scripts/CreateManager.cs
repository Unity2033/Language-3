using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] float offset = 1.5f;
    [SerializeField] GameObject elemental;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject clone = Instantiate(elemental, transform);

            clone.transform.position = new Vector3(-3 + (1.5f * i), 0, 0);
        }
    }
}
