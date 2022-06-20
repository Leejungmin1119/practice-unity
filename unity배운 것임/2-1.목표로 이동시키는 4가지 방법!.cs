using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 흐름 : MonoBehaviour
{
    Vector3 target = new Vector3(14f,1.5f,0);
    
    void Update()
    {
        //목표 지점으로 이동시키는 4가지 방법!

        /*목표지점으로 이동시키기 위해서는 기본적으로 transform.position을 이용해야 한다.
          ex) transform.position = Vector3.(이용할 함수)(다양한 값들);
        */

        //1.MoveTowards(현재 위치,목표위치,속도)

        transform.position = Vector3.MoveTowards(transform.position, target,1f);

        //2.SmoothDamp(부드러운 이동)(현재위치,목표위치,참조속도,속도)
        // !! 마지막 매개면수에 반비례하여 속도가 증가하는 방식임
        
        Vector3 vec = Vector3.zero;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref vec, 0.3f);
        

        //3.Lerp(선형보간)(현재 위치,목표위치,속도(최댓값 1))

        transform.position = Vector3.Lerp(transform.position, target, 0.03f);

        //4.Slerp (구형 선형 보간)(포물선)
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);

        
    }
}
