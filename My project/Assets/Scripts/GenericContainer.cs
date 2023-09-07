using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���ʸ� �������� class ����
public class GenericContainer<T>
{
    private T[] items;                  //Ŀ���� �迭
    private int currentindex = 0;       //item ���� ��ȣ

    public GenericContainer(int capacity)   //�����ɶ� �迭 ���� ����
    {
        items = new T[capacity];            //�Լ��� ���ؼ� �޾ƿͼ� �迭 ����
    }
    public void Add(T item)
    {   //�迭�� �������� ���̻� ���� ����
        if (currentindex < items.Length)
        {
            items[currentindex] = item;     //���� �������� ��ȣ�� ���ؼ� �迭�� �ִ´�.
            currentindex++;                 //������ ��ȣ�� ������Ų��.
        }
    }

    public T[] Getitems()
    {//������ �迭�� Return ��
        return items;
    }
}
