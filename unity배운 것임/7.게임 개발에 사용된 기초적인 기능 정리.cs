using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * 
 * 1.플레이어 점프 Input.GetButtonDown("Jump")
 * 
 * 무한 점프를 막기 위해 불연산을 사용 점프를 하면 비활성화 되고 
 * 땅이라는 tag에 닿게 되면 활성화 되는 형식.
 * 
 * private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "땅")
    {
        jump_player = false;
    }    
}
    2.물체이동 
    
    물체를 이동하기 위해서 먼저 rigid body 컴포넌트를 불러온다.
    
    백터 지정 한후 

    Vector3 vec = new Vector3(Input.GetAxisRaw("왼오") * speed, 0, Input.GetAxisRaw("위아래") * speed);
     
    Addforce라는 rigid body함수를 이용하여 가속도가 구현되어 있는 3차원 이동키를 만든다.

    rigid.AddForce(vec * Time.deltaTime, ForceMode.Impulse);

    여기에서  speed라는 변수는 public 변수로서 unity실행창에서 직접 설정이 가능하다.

    또한 Time.deltaTime을 이용하여 프레임 상관없이 속도변화가 같다.

    3.트리거(엘리베이터)

    위로 올라가는 장판 시스템을 구현하기 위해서 먼저 물체를 만들어 준뒤 그 물체를 트리거로 지정한다.

    트리거 지정후 장판 시스템은 트리거와 플레이어가 닿고 있는 도중에 발생해야 한다 그렇기 떄문에
    
    private void OnTriggerStay(Collider other)// 트리거와 접촉하고 있을 경우에 발생하는 이벤트
    {
        if (other.tag == "위")//만약 "위"라는 태그를 가지고 있는 것과 접촉하고 있는 경우?
        {
         rigid.Addforce(Vector3.up * 60, ForceMode.Impulse);//위로 벡터값을 60정도 준다.
        }
    }
    4.트리거(코인),위험벽
    
    코인또한 먹었을때 어떤 힘이 가하지 않아야 하므로 트리거로 설정한다.
    
    그리고 코인은 stay가아닌 닿았을때 발생하는 이벤트이다.

    코인을 먹었을때의 소리또한 추가하고 코인을 회전하게 할 것이다.

        void Update()//코인 회전
        {
            transform.Rotate(Vector3.up*turn_speed*Time.deltaTime,Space.World);
        }

    위험벽은 닿았을때 다시 처음 위치로 초기화 시켜야 한다.

    따라서 using UnityEngine.SceneManagement을 불러와야한다.
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "item")
        {
            
            audios.Play();
            other.gameObject.SetActive(false);//코인이라는 트리거와 닿을 경우 그 물체가 비활성화 됨.
            coins++;
            manager.Getcount(coins);

        }
        else if (other.tag == "위험")
        {
            SceneManager.LoadScene("stege_" + manager.stage_level.ToString());
        }

        여기서 manager.Getcount(coins) 은 다른 c# 파일에서 불러온 것으로 

        먹었을시 코인의 갯수를 Getcount라는 함수에 coins의 갯수를 업데이트 한다.

        또한 public gamehelper(다른 파일이름) manager(변수이름)을 사용해야지 다른 파일에서 불러올수가 있다.

        //ToString()은 문자열로 Scene의 이름을 문자열로 인식하게 해주며 없으면 글자로 보지 못해서 오류가 난다.

    }
    5.결승점

    결승점에 도달했을시 코인을 다먹었는지 아닌지에 따라 클리어 or 재시도를 구분지을 것이다.

    일단 using UnityEngine.SceneManagement을 이용한 후

    클리어면  SceneManager.LoadScene("stege_" + (manager.stage_level + 1).ToString());

    로 그다음으로 Scene로 이동하도록 하고, 만약 아니라면

    SceneManager.LoadScene("stege_" + manager.stage_level.ToString());을 실행시킨다.

    6.카메라

    카메라는 먼저 플레이어를 따라가야 한다. 그리고 또 한가지의 조건은

    플레이어랑 겹치지 않고 적절한 위치에서 플레이어가 움직일때 카메라도 똑같이 움직어야 한다.

    일단 카메라에 집어넣을 c# 폴더를 생성한 후 

    벡터값을 가지는 변수를 지정한 후 void Awake() 에서

    playertransform = GameObject.FindGameObjectWithTag("Player").transform;
    offset = transform.position - playertransform.position;을 실행후

    transform.position = playertransform.position+offset;으로 플레이어랑 거리를 두게 한다.

   


        
 */


