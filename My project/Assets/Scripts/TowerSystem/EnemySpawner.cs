using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyConroller[] enemiesToSpawn;      //몬스터 종류 배열 값

    public Transform spawnPoint;

    public float timeBetweenSpawns = 0.5f;             //스폰 사이 시간
    private float spawnCounter;                 //숫자를 카운팅하는 변수

    public int amountToSpawn = 15;              //스폰될때 몬스터 숫자

    void Start()
    {
        spawnCounter = timeBetweenSpawns;
    }

    void Update()
    {
        if(amountToSpawn > 0 )  //남아있는 스폰될 숫자가 있을때
        {
            spawnCounter -= Time.deltaTime;         //프레임마다 시간을 감소 시킴
            if(spawnCounter <= 0)                   //spawnCount 0이하일때
            {
                spawnCounter = timeBetweenSpawns;   //정해진 스폰 사이 간격 시간을 다시 리셋
                //Ransdom,Range(0, enemiesTosSpawn.Length) 배열안의 랜덤값을 정해서 프리팹을 생성 위치랑 로테이션 값
                Instantiate(enemiesToSpawn[Random.Range(0, enemiesToSpawn.Length)], spawnPoint.position, spawnPoint.rotation);

                amountToSpawn--;                    //스폰될 숫자를 빼준다
            }
        }
    }
}
