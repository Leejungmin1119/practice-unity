using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 이동키 : MonoBehaviour
{
    void Update()
    {
        //입력 함수는 크게 세가지로 구성 (키보드를 누를때,키보드를 땔때,키보드를 누르고 있을때)

        //1.아무 키를 누를 때
        if(Input.anyKeyDown) 
        {
            Debug.Log("키를 눌렀습니다.");
        }
        if(Input.anyKey)
        {
            Debug.Log("플레이어가 키를 누르고 있습니다.");
        }
        //2.키보드에서 특정한 키를 입려받을때,누르고 있을때 또는 땔때
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템 구입완료!");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동중임~");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 이동중이당~");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽키 스탑!");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽키 스탑!");
        }
        //3.마우스에서 특정한 키를 입력받을때,누르고 있을때 또는 땔때
        if (Input.GetMouseButton(0))
        {
            Debug.Log("기술 차징중!");

        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("차징 기술 발싸!");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("평타공격!");
        }
        //4.unity가 정해준 키를 이용해도 된다.
        //방법. Edit -> project Settings -> Input Manager -> 자기가 원하는 키 설정 = 사용하기
        if(Input.GetButton("Jump"))
        {
            Debug.Log("점프 차징중!");
        }
        if(Input.GetButtonUp("Jump"))
        {
            Debug.Log("점-------프!");
        }
        if(Input.GetButton("Jump"))
        {
            Debug.Log("일반 점프!");
        }
    }
}
