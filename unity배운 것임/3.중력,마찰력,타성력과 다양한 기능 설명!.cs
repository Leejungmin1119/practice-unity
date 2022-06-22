using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 흐름 : MonoBehaviour
{
    
    void Update()
    {
        //오브젝트에 중력을 적용하기 위해서 Rigidbody를 적용한다.
        //Rigidbody : 중력을 적용시켜준다.
        /*
         * Rigidbody의 기능들
         * 
         * 1.mass : 무게 설정.
         * 2.Use Gravity : 중력 사용 여부
         * 3.Is Kinemaatic : 외부의 물리적인 효과 무시 : 외부 작용을 안 받기때문에 장애물을 만들기에 용이하다.
         */



        //추가적인 기능
        //sphere Collider : 닿는 범위를 정할 수 있고 설정을 끄게되면 물체를 통과하게 된다.
        //Material : 오브젝트의 표면 재질을 결정한다.
        /*
         * !! Material은 기본적안 설정을 바꿀 수 없으며 바꾸기 위해서는 Assets에서 
         * Material을 선택해서 만들고 만들것을 끌여다 써야된다.
         * 
         * Material의 기능
         * Metallic : 금속재질 설정 오른쪽에 가까울수록 금속처럼 보이게 된다.
         * smoothness : 광택 설정, 오른쪽에 가까울수록 반사가 더 잘된다.
         * Tiling : 텍스쳐 반복타일의 개수 설정
         * Emission : 텍스쳐 발광 조절
         * 
         * ++
         * Albedo에 그림을 끌어다가 넣어서 적용이 가능하다.
         */
        Debug.Log("2202.06.21");

    }
}
