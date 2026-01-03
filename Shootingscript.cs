using UnityEngine;

public class Shootingscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject laserPrefab;
    public GameObject gun;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("FiringLaser");
            laserPrefab.GetComponent<LineRenderer>().SetPosition(0,
                gun.transform.position);
        }
    }
}
