using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool forward, backward;
    private Vector2 vector;
    private float speedX, speedY;
    [SerializeField] private float forceY;

    [SerializeField] private float rotatespeed = 100f;




    // Update is called once per frame
    void Update()
    {
        Inputs();
        Move();
        Force();
        Rotate(); 

      

    }

    private void Inputs(){
        forward = Input.GetKey(KeyCode.W);
        backward = Input.GetKey(KeyCode.S);
    }

    private void Move(){

        if (forward && !backward){
            speedY += forceY * Time.deltaTime;
        }else if (!forward && backward){
            speedY -= forceY * Time.deltaTime;
        }

      
    }

    private void Force(){
        transform.position += new Vector3(speedX, 0f);
        transform.position += transform.up * speedY;
    }

    private void Rotate(){
            double dx = Input.mousePosition.x - Screen.width / 2.0;
            double dy = Input.mousePosition.y - Screen.height / 2.0;
            float sdx = (float)dx;
            float sdy = (float)dy;
            

            float sR = Mathf.Atan2(sdx, sdy);
            float sD = 360 * sR / (-2 * Mathf.PI);

            float startAngle_x = transform.rotation.eulerAngles.x;
            float startAngle_y = sD;
            float startAngle_z = transform.rotation.eulerAngles.z;

            Quaternion target = Quaternion.Euler(startAngle_x, 0f, sD);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, Time.deltaTime * rotatespeed);
    }
}
