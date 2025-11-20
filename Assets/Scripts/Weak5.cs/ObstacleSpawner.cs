using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float interval = 1.0f;

    public GameObject obs;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;
            float x = Random.Range(-3f, 3f); 
            GameObject obs = Instantiate(obstaclePrefab, new Vector3(x, 6f, 0), Quaternion.identity);

            // ¥ ‘å‚«‚³‚ğƒ‰ƒ“ƒ_ƒ€‚É
            float size = Random.Range(0.5f, 1.5f);
            obs.transform.localScale = new Vector3(size, size, 1f);
        }
    }
}
