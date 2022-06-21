using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 흐름 : MonoBehaviour
{
    Vector3 target = new Vector3(14f,1.5f,0);
    
    void Update()
    {
        //추가 내용
        //델타타임(Time.deltaTime) :이전 프레임의 완료까지 걸린 시간
        /*
         * 게임을 돌릴때 컴퓨터에 성능에 따라 프레임이 다르기 때문에
         * 업데이트(Update)가 실행되는 횟수가 다름.
         * 
         * 성능에 따라 같은 아이템(예를 들어 카트라이더 차)를 탄다 해도
         * 
         * 속도가 달라짐! 
         * 
         * 델타타임은 이를 막는 역할을 한다.
         */
        //1.translate 에서 사용하는 경우
        
        Vector3 vec = new Vector3(Input.GetAxis("왼오"), Input.GetAxis("위아래"), 0);
        transform.Translate(vec *Time.deltaTime);
        
        //2.transform.position에서 사용하는 경우
        transform.position = Vector3.Slerp(transform.position, target,1.5f*Time.deltaTime);

    }
}
