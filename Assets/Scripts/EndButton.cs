using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    void Update()
    {

    }

    // ó������ ��ư �Լ�
    public void SceneChangeButton()
    {
        //SceneManager.LoadScene("Chap12");   // �ӽ� ��ȯ. ���� ����
        AudioSource sound2 = GetComponent<AudioSource>();
        sound2.Play();
        SceneManager.LoadScene("Title");
        Debug.Log("ó������ �̵�");
    }

    // ���� ���� ��ư �Լ�
    public void ExitButton()
    {
        Application.Quit();
        AudioSource sound2 = GetComponent<AudioSource>();
        sound2.Play();

        Debug.Log("���� ����");
    }
}
