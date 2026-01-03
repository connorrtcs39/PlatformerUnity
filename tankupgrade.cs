using UnityEngine;

public class tankupgrade: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float upgradeValue = 10f;
    public Movement player;
    void OnCollisionEnter(Collision c)
    {
        Debug.Log("test");
        if (c.gameObject.tag == "Player")
        {
            player.capacity += upgradeValue;
            Destroy(this.gameObject);
        }
    }
}
