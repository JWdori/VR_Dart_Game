using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Pop_Fail : MonoBehaviour
{ 
    public ParticleSystem particleSystem;
    private GameManager3 gameManager;
    private bool popped = false; // �浹 �� �� ���� �����ϱ� ���� ����
    private Rigidbody balloonRigidbody;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager3>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (!popped)
        {
            particleSystem.gameObject.SetActive(true);

            ParticleSystem instantiatedParticleSystem = Instantiate(particleSystem, collision.contacts[0].point, Quaternion.identity);
            instantiatedParticleSystem.Play();

            // �浹 ��ġ�� ��ƼŬ �ý��� �۵�

            // ���� ����
            GameManager3 gameManager = FindObjectOfType<GameManager3>();
            gameManager.MissScore(1);
            gameManager.PrintFalse();
            GameManager3.state = GameManager3.STATE.WRONG;
            popped = true; // �� �� ����Ǿ����� ǥ��
        }


        // �浹�� ������Ʈ �ı�
        Destroy(gameObject);
    }
}