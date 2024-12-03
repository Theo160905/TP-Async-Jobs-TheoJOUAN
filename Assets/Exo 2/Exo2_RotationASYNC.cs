using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Exo2_RotationASYNC : MonoBehaviour
{
    private bool isRotate;
    private Task rotation;

    public async void StartRotation()
    {
        if (isRotate) return;

        rotation = RotateAsync();
        await rotation;
    }

    public void ToStop()
    {
        isRotate = false;
    }

    private async Task RotateAsync()
    {
        isRotate = true;

        for (int i = 0; i < 500 && isRotate; i++)
        {
            transform.Rotate(0f, -5f, 0, Space.World);

            await Task.Delay(10);
        }

        isRotate = false;
    }
}
