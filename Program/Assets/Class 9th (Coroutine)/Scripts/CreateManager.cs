using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] float offset = 1.5f;
    [SerializeField] GameObject elemental;

    [SerializeField] List<GameObject> list;
    [SerializeField] WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    [SerializeField] int count;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject clone = Instantiate(elemental, transform);

            clone.transform.position = new Vector3(-3 + (1.5f * i), 0, 0);

            clone.SetActive(false);

            list.Add(clone);
        }

        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while (count < list.Count)
        {
            list[count++].SetActive(true);

           yield return waitForSeconds;
        }
    }
}
