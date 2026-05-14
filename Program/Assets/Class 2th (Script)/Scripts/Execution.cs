using UnityEngine;

public class Execution : MonoBehaviour
{
    private void Awake()
    {
        // Awake 함수
        // 게임 오브젝트가 생성되었을 때 단 한 번만 호출되며,
        // 스크립트가 비활성화되어 있어도 호출되는 이벤트 함수입니다.
      
        Debug.Log("Awake");       
    }

    private void OnEnable()
    {
        // OnEnable 함수
        // 게임 오브젝트가 활성화되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start 함수
        // 게임 오브젝트가 생성되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate 
        // 물리 시스템에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수입니다.

        Debug.Log("Fixed Update");
    }

    private void Update()
    {
        // Update
        // 매 프레임마다 호출되는 이벤트 함수입니다.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate
        // Update 함수가 끝나고 난 후에 호출되는 이벤트 함수입니다.

        Debug.Log("Late Update");
    }

}
