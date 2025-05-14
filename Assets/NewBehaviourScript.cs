using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
/*
    public float moveSpeed = 50f;
    public float depth = 10f;

    void Update()
    {
        // Get the mouse position in screen space.
        Vector2 mousePosition = Input.mousePosition;

        // Convert the screen position to a world point.
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, depth));

        //Quaternion rotationPosition = new Quaternion(mousePosition.x, mousePosition.y, depth, 1f);

        //Quaternion rotationPosition = Quaternion.Euler(mousePosition.x, mousePosition.y, depth);
        Quaternion rotationPosition = Quaternion.Euler(worldPosition);
        Vector3 locationPosition = new Vector3(0f, 1f, 0.7f);

        //rotationPosition.Set(mousePosition.x, mousePosition.y, depth, 1f);

        // Previous:
        //transform.Rotate(mousePosition.x, mousePosition.y, depth, Space.Self);

        //Best rn:
        //transform.Rotate(worldPosition, Space.Self);

        transform.SetLocalPositionAndRotation(locationPosition, rotationPosition);
    }

*/
    public float rotationSpeed = 10f; // Optional: For smoother rotation

    void Start() {
        
    }
    void Update()
    {
        // 1. Get mouse position in world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10));

        // 2. Calculate direction
        Vector3 direction = mousePosition - transform.position;
        direction.Normalize();

        // 3. Rotate the object (using LookAt)
        transform.LookAt(mousePosition + new Vector3(0, -8, 0));

        // Optional: Smooth rotation (using Quaternion.Slerp)
         Quaternion targetRotation = Quaternion.LookRotation(direction);
         transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
