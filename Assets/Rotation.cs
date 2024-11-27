using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Coroutine coroutine;
    bool IsRotate;

    public void StartRotation()
    {
        if (IsRotate == true) return;
       coroutine = StartCoroutine(ToRotate());
    }

    public void ToStop()
    {
        StopCoroutine(coroutine);
        IsRotate = false;
    }

    public IEnumerator ToRotate()
    {
        IsRotate = true;
        for (int i = 0; i < 500; i++)
        {
            gameObject.transform.Rotate(0f, -5f, 0, Space.World);
            yield return new WaitForSeconds(0.01f);
        }
        IsRotate = false;
    }
}
