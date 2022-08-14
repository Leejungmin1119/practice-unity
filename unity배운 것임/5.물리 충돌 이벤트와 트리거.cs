using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_effects: MonoBehaviour
{
    Rigidbody rigid;
    //1.물리 이벤트

    //오브젝트 접근!
    //오브젝트 재질 = MeshRenderer이용.
    MeshRenderer mesh;//MeshReder 기능 가져오기
    Material mat;// MeshRender에 있는 기능들 중 Material 기능 가져오기.


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();//컴포넌트 불러오기    
        //mesh 안에 있는 material 기능을 불러온다.

        //(material을 저장할 변수명) = (MeshRender 변수명).material;

        mat = mesh.material;

    }
    private void OnCollisionEnter(Collision collision)//물리적 충동이 일어났을때 사용되는 함수.(물리적 충동이 사작이 됬을때)
    {
        //Collision = 충돌 정보 클래스 => 충돌에 대한 정보를 가지고 있다.

        //collision.gameObject.name == "(붙이치는 물체의 이름)"
        if(collision.gameObject.name == "Sphere (1)")//만약 "공"이라는 이름을 가진 물체랑 충돌을 하면?
        {
            //Color = 기본 색상 , Color32 = 255 색상 클래스

            //충돌했을때의 색상을 변경한다.
            mat.color = new Color(0, 0, 0);//(0,0,0) = 블랙 , (1,1,1) = 횐색

        }
    }
    private void OnCollisionStay(Collision collision)//충돌이 지속되고 있을때 사용되는 함수.
    {
        
    }
    private void OnCollisionExit(Collision collision)//물리w적 충돌이 끝났을떄 사용되는 함수.
    {
        mat.color = new Color(1, 1, 1);

    }



    //2.트리거

    private void OnTriggerStay(Collider other)//트리거에 닿고 있는 도중에 사용되는 함수.
    {


        //+ collision 이 아닌 Collider가 사용된 이유?

        //트리거는 겹쳤는지 안 겹쳤는지만 알아도 되기때문에 물리적인 충돌정보가 없어도 된다.
        if (other.name == "up Cube")//만약에 "up Cube"라는 물체랑 겹쳤을 경우?
        {
            rigid.AddForce(Vector3.up, ForceMode.Impulse);//그 물체를 위로 힘을 가한다.
            //!! 적용시키기 위해서는 이것 뿐만 아니라 대상 물체에 트리거를 적용시켜야 가능하다.
        }
    }



}
