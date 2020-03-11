using UnityEngine;
public class enemySpawnController : MonoBehaviour
{
    public GameObject npc;
    public float ForwardStep = 0.1f;
    private float height;
    private float width;
    void Start()
    {
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
        InvokeRepeating("createNPC", 0f, 1.0f);

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void createNPC()
    {
        float posX = Random.Range(-width, width);
        GameObject tempGo = Instantiate(npc, new Vector2(posX, height + 2), Quaternion.identity) as GameObject;
        Object.Destroy(tempGo, 5.0f);
    }
}
