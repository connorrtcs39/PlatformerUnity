using UnityEngine;

public class fueltankcollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float upgradeValue = 5f;
    public Movement player;
  void OnCollisionEnter(Collision c)
    {
        Debug.Log("test");
        if (c.gameObject.tag == "Player")
        {
            player.speed += upgradeValue;
            Destroy(this.gameObject);
        }
    }
}
