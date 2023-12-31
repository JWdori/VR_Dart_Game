using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bhaptics.SDK2;

public class reset_button : MonoBehaviour
{
    public GameObject[] targetObjects;
    private Rigidbody[] targetRigidbodies;

    bool isLeft = false;
    bool isRight = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("left_hand"))
        {
            //BhapticsLibrary.Play(BhapticsEvent.CORRECT_LEFT);
            isLeft = true;
        }
        else if (collision.gameObject.CompareTag("right_hand"))
        {
            //BhapticsLibrary.Play(BhapticsEvent.CORRECT_RIGHT);
            isRight = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("left_hand"))
        {
            //Debug.Log("Left Hand");
            isLeft = false;
        }
        else if (collision.gameObject.CompareTag("right_hand"))
        {
            //Debug.Log("Right Hand");
            isRight = false;
        }
    }

    // 아래의 0부터 9까지의 위치는 편의상 0,0,0으로 초기화하였으며, 유니티 인스펙터에서 각각 원하는 위치로 수정하시면 됩니다.
    public Vector3[] targetPositions = new Vector3[1]
    {
        new Vector3(0.231f,1.368f,0.375f),

    };

    private void Start()
    {
        targetRigidbodies = new Rigidbody[targetObjects.Length];

        for (int i = 0; i < targetObjects.Length; i++)
        {
            targetRigidbodies[i] = targetObjects[i].GetComponent<Rigidbody>();
        }
    }

    public void MoveObjectsToPosition()
    {       
        if (targetObjects != null && targetRigidbodies != null)
        {
            if (isLeft)
            {
                Debug.Log("Left");
                BhapticsLibrary.Play(BhapticsEvent.CORRECT_LEFT);
            }
            else if (isRight)
            {
                Debug.Log("Right");
                BhapticsLibrary.Play(BhapticsEvent.CORRECT_RIGHT);
            }
            for (int i = 0; i < targetRigidbodies.Length; i++)
            {
                Rigidbody targetRigidbody = targetRigidbodies[i];
                GameObject targetObject = targetObjects[i];

                if (targetRigidbody && !targetRigidbody.IsSleeping())
                {
                    targetRigidbody.isKinematic = true;
                }

                // 각 오브젝트를 해당하는 위치로 이동합니다.
                targetObject.transform.position = targetPositions[i];
                targetObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                
                
                if (targetRigidbody)
                {
                    targetRigidbody.isKinematic = false;
                }
            }
        }
        else
        {
            Debug.LogWarning("Target objects or Rigidbody components are not assigned.");
        }
    }
}
