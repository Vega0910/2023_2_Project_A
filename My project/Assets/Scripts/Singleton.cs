using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }          //인스턴스를 전역에 선언
    // Start is called before the first frame update
    public void Awake()
    {
        if (Instance == null)                                        //Instance가 NULL일때
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);                          //게임 오브젝트가 Scene이 전환되고 파괴되지 않음
        }
        else
        {
            Destroy(gameObject);                                    //1개로 유지시키기 위해 생성된 객체를 파괴한다.
        }
    }

    public int playerScore = 0;

    // Update is called once per frame
    public void InscreaseScore(int amount)
    {
        playerScore += amount;
    }
}
