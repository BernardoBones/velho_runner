using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 6;
    public float horizontalSpeed = 3;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    public static float timePlayed = 0f;
    public float speedIncreaseRate = 0.5f; // Quanto a velocidade aumenta por segundo
    public float maxSpeed = 20f;           // Velocidade máxima permitida

    // Update is called once per frame
    void Update()
    {
        timePlayed += Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }

        }
        // Aumenta gradualmente a velocidade até o máximo
        if (playerSpeed < maxSpeed)
        {
            playerSpeed += speedIncreaseRate * Time.deltaTime;
        }
    }
}
