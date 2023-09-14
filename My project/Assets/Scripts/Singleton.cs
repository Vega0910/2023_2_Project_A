using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }          //�ν��Ͻ��� ������ ����
    // Start is called before the first frame update
    public void Awake()
    {
        if (Instance == null)                                        //Instance�� NULL�϶�
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);                          //���� ������Ʈ�� Scene�� ��ȯ�ǰ� �ı����� ����
        }
        else
        {
            Destroy(gameObject);                                    //1���� ������Ű�� ���� ������ ��ü�� �ı��Ѵ�.
        }
    }

    public int playerScore = 0;

    // Update is called once per frame
    public void InscreaseScore(int amount)
    {
        playerScore += amount;
    }
}
