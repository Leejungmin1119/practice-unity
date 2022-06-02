using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unity1 : MonoBehaviour
{

   /*
    int resurt(int money)
    {
        int count = 0;
        while (money >= 100)
        {
            money -= 100;
            count++;
        }
        return count;
    
    }
   */

    void Start()
    {


        //변수
        /*
        int a = 3;
        Debug.Log("지금 a의 값은 ?  : " + a);
        */

        /*
        * Debug.Log(); 으로 출력 가능하고
        * 변수는 전과 동일하지만 string을 선언할 수 있으며 
        * 말과 변수 동시에 출력할려면 +를 이용해 붙여야 한다.
        */
        //배열
        /*
        string[] arr = { "나는 문어" , "나는 사자" , "나는 기린" };
        int[] Level = new int[3];
        Level[0] = 1;
        Level[1] = 15;
        Level[2] = 28;
        string[] str = new string[3];
        str[0] = "우리 집";
        str[1] = "공원";
        str[2] = "대학교";

        Debug.Log(arr[0]);
        Debug.Log(Level[1]);
        Debug.Log("내가 있는 장소는?");
        Debug.Log(str[0]);
        */

        //리스트 선언

        /*
        List<string> language = new List<string>();
        language.Add("c언어");
        language.Add("c#");
        language.Add("unity");

        Debug.Log("내가 배우고 았는 언어는? ");
        Debug.Log(language[0]);
        Debug.Log(language[1]);
        Debug.Log(language[2]);
        */
        /*
        * 배열을 선언할려면 
        * 1.(int,string,char...)[] (배열의 이름) = {배열에 안에 저장될 변수의 이름}
        * 또는 
        * 2.(int,string,char...)[] (배열의 이름) = new (int,string,char...처음에 선언한 것과 동일하게)
        * (배열의 이름)[] = (배열에 저장될 변수의 이름)
        * 의 형식으로 배열을 선언할수가 있다!
        * 
        * int arr[3] ={};(X)(c언어), int[] arr = {};(O) 
         * 
         * 리스트는 2번과 비슷하지만 List<(자료형)>을 넣어야 하고
         * 추가할려면
         * (배열의 이름).Add(배열안에 저장될 변수의 이름) 과 같은 형식으로
         * 해야된다!
         */
        //연산자

        /*
        int playerLevel = 85;
        bool check = playerLevel >= 100;
        Debug.Log(check);
        string playLevel = check ? "높은 레벨" : "낮은 레벨";
        Debug.Log("당신의 레벨은 " + playLevel + "입니다!");
        */

        /*
         * 전에 배운 것과 같지만 추가로 알아야 할것은 bool 연산자로 
         * false 와 ture 이 두가지가 있으며 참인지 거짓인지 판별가능
        */


        //반복문 foreach

        /*
        string[] todayclass = new string[3];
        todayclass[0] = "가톨릭 사상";
        todayclass[1] = "독서와 토론";
        todayclass[2] = "이산수학";
        foreach (string crass in todayclass)
        {
            Debug.Log("월요일과  화요일에 있는 수업은 ?" +crass);

        }
        
        int money = 500;
        Debug.Log("100원짜리 "+resurt(money)+"개로 거슬러 주었습니다");
        */

        //클래스

        playerstats player = new playerstats();
        player.playerLevel = 0;




    }

}
