using UnityEngine;

public class ComatScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision) {
        gameObject.SetActive(false); // Deactivates the GameObject
        GetComponent<Renderer>().enabled = false; // Hides the object's visual representation
     }

    // Or, to trigger a different action based on the colliding object's tag
    // void OnCollisionEnter(Collision collision) {
    //    if (collision.gameObject.tag == "Player") {
    //        Destroy(gameObject);
    //    } else {
    //        Debug.Log("Collided with something, but not the player");
    //    }
    // }
}
