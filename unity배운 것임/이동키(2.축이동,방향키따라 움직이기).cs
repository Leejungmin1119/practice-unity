using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 이동키 : MonoBehaviour
{
    void Start()
    {
        //오브젝트 이동하기!
        Vector3 vec = new Vector3(0,0,0);//벡터 값, 현재 위치에서 (x,y,z) 만큼 더해줌
        //3차원이면 Vector3 2차원이면 Vector2 이런식으로 차원에 따라 벡터도 달라짐!
        transform.Translate(vec);//오브젝트 설정
    }
    void Update()
    {
        //횡 이동!
        //GetAxis라는 함수를 이용하여 횡이동을 할수가 있다!
        //GetAxis를 이용해서 왼쪽으로 가고 있는지 오른쪽으로 가고 있는지 알게 할 수 있다
        if(Input.GetButton("왼오"))
        {
            if(Input.GetAxis("왼오") >= 0)
            {
                Debug.Log("오른쪽으로 이동중입니다!" + Input.GetAxis("왼오"));
            }
            else
            {
                Debug.Log("왼쪽으로 이동중입니다!" + Input.GetAxis("왼오"));
            }
        }
        //또한 Raw라는 걸 추가 시켜 더 쉽고 간편하게 알수 있다.!
        if(Input.GetButton("왼오"))
        {
            Debug.Log("왼쪽 == -1 , 오른쪽 == 1\n"+Input.GetAxisRaw("왼오"));
        }
        if(Input.GetButton("위아래"))
        {
            Debug.Log("아래 == 1 , 위 == 1\n" + Input.GetAxisRaw("위아래"));
        }
        //키보드에 따라 오브젝트 이동하기!
        if(Input.GetButton("위아래"))
        {
            if(Input.GetAxis("위아래") >0)
            {
                Vector3 vec = new Vector3(0, 0.03f, 0);
                transform.Translate(vec);
            }
            else if(Input.GetAxis("위아래") < 0)
            {
                Vector3 vec = new Vector3(0, -0.03f, 0);
                transform.Translate(vec);
            }
 
        }
        if(Input.GetButton("왼오"))
        {
            if(Input.GetAxis("왼오") > 0)
            {
                Vector3 vec = new Vector3(0.03f, 0, 0);
                transform.Translate(vec);
            }
            if(Input.GetAxis("왼오") < 0)
            {
                Vector3 vec = new Vector3(-0.03f, 0, 0);
                transform.Translate(vec);
            }
        }

     

        

    }
}
