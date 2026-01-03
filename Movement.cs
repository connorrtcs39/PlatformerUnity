using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;
    public Rigidbody rb;
    private Vector3 spawn;
    public float capacity;
    public float fuel;
    public float fuelDecrease;
    public float fuelRegen;
    public bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
       
    {
    rb = gameObject.GetComponent<Rigidbody>();
    spawn = transform.position;
    }

    // Update is called once per frame
    void Update()

    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed;
        if (Input.GetAxisRaw("Jump") > 0 && fuel > 0)
        {
            rb.AddForce(transform.up * 1000 * Time.deltaTime);
            fuel -= fuelDecrease * Time.deltaTime;
            isGrounded = false;
        }
        if (isGrounded)
        {
            if (fuel < capacity)
            {
                fuel += fuelRegen * Time.deltaTime;
            }
            else
            {
                fuel = capacity;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        }
        private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 500);
        }
        if (collision.gameObject.tag == "Death Cube")
        {
            transform.position = spawn; 
        }
        if (collision.gameObject.tag == "ground")
        isGrounded = true;
    }
}

