using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    GameObject item; //������ ������Ʈ
    GameObject player;  // �÷��̾� ������Ʈ
    public GameObject itemTalk;     // ���Ǳ� ��ɾ�

    Boolean getItem = false;    // ������ ���������� ����

    void Start()
    {
        player = GameObject.Find("Player");
        item = GameObject.FindWithTag("Item");
        item.SetActive(false);
    }

    void Update()
    {
        // ���Ǳ� ��ó����, ������ �Ȱ��������� Ȯ��
        if (gameObject.transform.position.x - 2 <= player.transform.position.x && player.transform.position.x <= gameObject.transform.position.x + 2)
        {

            if (getItem == false)
            {
                itemTalk.SetActive(true);
            }

        }
        else
        {
            itemTalk.SetActive(false);
        }

        if (Input.touchCount > 0)
        {
            Debug.Log("������ ȹ��");
            item.SetActive(true);
            getItem = true;
            itemTalk.SetActive(false);
        }
    }

    //test code
    private void OnMouseDown()
    {
        AudioSource itemget = GetComponent<AudioSource>();
        itemget.Play();
        Debug.Log("������ ȹ��");
        item.SetActive(true);
        getItem = true;
        itemTalk.SetActive(false);
    }
}
