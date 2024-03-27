using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float dashCoolTime;
    public Vector3 dashForce;
    public Rigidbody rb;
    public Camera camera;
    float moveX;
    float moveZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move();

        // 移動量
        moveX = Input.GetAxis("Horizontal") * moveSpeed; // 左右
        moveZ = Input.GetAxis("Vertical") * moveSpeed; // 前後

        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(camera.transform.forward, new Vector3(1, 0, 1)).normalized;
        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 move = cameraForward * moveZ + camera.transform.right * moveX;

        transform.position += move*Time.deltaTime;
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A)) transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D)) transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W)) transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) transform.position += new Vector3(0, 0, -moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(dashForce, ForceMode.Impulse);
    }
}
