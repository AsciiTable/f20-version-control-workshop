using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    int moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveSpeed, 0, 0) * Input.GetAxis("Horizontal") * Time.deltaTime;

        if (transform.position.y <= -20)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
