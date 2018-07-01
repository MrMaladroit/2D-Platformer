using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private int playerMovementSpeed = 10;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical);

        Debug.Log("Movement = " + movement);

        transform.position += movement * playerMovementSpeed * Time.deltaTime;
    }
}