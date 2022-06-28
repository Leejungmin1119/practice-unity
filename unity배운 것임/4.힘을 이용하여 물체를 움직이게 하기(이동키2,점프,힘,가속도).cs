using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 이동키ver2 : MonoBehaviour
{
    //1.컴포넌트 가져오기
    //코드 흐름 외에서 실행을 한다.

    //Rigidnody(중력)
    //Rigidbody (변수 이름); 으로 사용한다.
    Rigidbody rigid;
    void Start()
    {
        //변수를 초기화하여 중력의 기능을 가지고 있는 컴포넌트를 가져온다.
        //GetComponent = 컴포넌트를 가져와줌
        //(변수 이름) = GetComponent<(선언 타입)>();
        rigid = GetComponent<Rigidbody>();

        //velocity : 현재 이동속도
        //(변수 이름).veloccity = Vector3.(right,left);

        /*
        rigid.velocity = Vector3.right;
        */
        //-------------------------------------------------------------------------------------

        //3.물체에 힘을 가해서 움직이기

        //AddForce(Vec) : Vec의 방향과 크기로 힘을 줌
        //힘을 주는 방식(가속,무게 포함)
        //[imoulse] = [느리게]
        //check! : Vector3.Up[대문자] (x),Vector.up[소문자
        //] (O) 

        /*
        rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);//점프키 할때 이런 식으로 구성한다.
        */


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //2.물체 속도 설정해서 움직이기
        //!! Rigidbody 관련 코드는 FixedUpdate에서 하는 것이 더 안전한다.(추천)

        //velocity : 현재 이동속도
        //(변수 이름).veloccity = Vector3.(right,left);

        /*
         * v!
        rigid.velocity = Vector3.right;
        */

        // ++받는 힘을 설정을 하는법

        /* v!
        rigid.velocity = new Vector3(1, 0.5f, 1);
        */

        //3.물체에 힘을 가해서 움직이기
        //점프 키 만들기!(3번 활용)
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("누른 상태");
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            // 점프 버튼을 연속으로 하게 되면 가속도가 붙어 더 높게 날라가게 된다.
        }

        //3d방향키 구현! 
        Vector3 vec = new Vector3(Input.GetAxisRaw("왼오"), 0, Input.GetAxisRaw("위아래"));
        rigid.AddForce(vec, ForceMode.Impulse);
        Debug.Log(rigid.velocity);

        //4.방향키.

        //AddTorque  :Vec 방향을 축으로 방향력이 생김.
        rigid.AddTorque(Vector3.up);





    }
    void Update()
    { 
    }
}
