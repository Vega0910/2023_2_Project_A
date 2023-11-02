using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealthController : MonoBehaviour
{
    public int totalHealth;     //ü�� ����

    public int moneyOnDeath = 50;

    public void TakeDamage(int damageAmount)
    {
        totalHealth -= damageAmount;

        if(totalHealth <= 0)
        {
            totalHealth = 0;
            Destroy(gameObject);
            //�̱������� ���� �÷��ִ� ó�� �Լ�
            //���� ���� ó�� ���� ���⼭ ���ش�.
        }
    }
}
