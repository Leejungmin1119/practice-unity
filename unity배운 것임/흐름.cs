using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 흐름 : MonoBehaviour
{
    //1.초기화 영역
    //게임 오브젝트를 생성할 때 최초로 실행이 되는 함수,1번만 실행
    void Awake()
    {
        Debug.Log("플레이어가 데어터를 동기화 했습니다.");
    }

    //오브젝트 활성화
    //게임오브젝트가 실행되었을때
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인 하였습니다!");
    }

    //2.업데이트를 하기 직전에 최초로 실행이 되는 함수,1번만 실행
    void Start()
    {
        Debug.Log("플레이어가 게임을 시작합니다.");
    }

    //3.물리연산
    //물리 연산 업데이트.꾸준히 호출을 하기 때문에 cpu를 많이 사용하게 된다
    void FixedUpdate()
    {
        Debug.Log("플레이어가 이동합니다");
    }

    //4.게임로직
    //게임 로직 업데이트,환경에 따라 실행주기가 달라질 수 있음
    void Update()
    {
        Debug.Log("몬스터를 잡는중..ㄷㄷ");
    }

    //5.모든 업데이트가 끝난 후 실행이 되는 함수,후처리 역할을 맞고 Update랑 실행횟수가 같다.
    void LateUpdate()
    {
        Debug.Log("몬스터에게 경험치 뜯었 ㄸㅇ!");
    }

    //비활성화
    //게임 오브젝트가 비활성화 됬을때
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃!");
    }

    //6.헤체
    //기록이나 등등을 무엇을 남기고 종료가 되게 된다.
    void OnDestroy()
    {
        Debug.Log("플레이어가 게임을 종료하였습니다.");
    }

}
