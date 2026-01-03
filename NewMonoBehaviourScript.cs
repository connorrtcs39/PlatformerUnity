using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform destination;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = destination.position;
        }
    }
     

    // Update is called once per frame
    
    
        
    
}
