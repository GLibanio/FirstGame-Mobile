using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson_Cam : MonoBehaviour
{
    public Camera Cam_Principal;
    public Camera Cam_Cutscene;

    public Transform characterBody;
    public Transform characterHead;

    float sensY = 0.2f;
    float sensX = 0.2f;

    float rotationX = 0;
    float rotationY = 0;

    float smoothRotx = 0;
    float smoothRoty = 0;
    float smoothCoeFx = 0.5f;
    float smoothCoeFy = 0.5f;

    float angleYmin = -60;
    float angleYMax = 60;

    [HideInInspector]
    public Vector2 LookAxis;
    void Start()
    {
        Cam_Cutscene.enabled = false;
        Cam_Principal.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        transform.position = characterHead.position;
    }
    void Update()
    {
        if(Time.timeScale != 0)
        {
            //Pega a movimenta��o do mouse e multiplica pela sensibilidade
            float VerticalDelta = LookAxis.y * sensY;
            float HorizontalDelta = LookAxis.x * sensX;

            //Suaviza a movimenta��o da c�mera
            smoothRotx = Mathf.Lerp(smoothRotx, HorizontalDelta, smoothCoeFx);
            smoothRoty = Mathf.Lerp(smoothRoty, VerticalDelta, smoothCoeFy);

            //Adiciona o valores 1, 0 ou -1 para a rota��o da c�mera
            rotationX += HorizontalDelta;
            rotationY += VerticalDelta;

            //Limita a rota��o no Y para que n�o de um loop
            rotationY = Mathf.Clamp(rotationY, angleYmin, angleYMax);

            // o Player muda o �ngulo para que va para onde a c�mera apontar
            characterBody.localEulerAngles = new Vector3(0, rotationX, 0);

            //passa a rota��o da c�mera
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
    }
}
