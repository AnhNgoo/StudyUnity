using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float hightRange = 0.45f;
    [SerializeField] private GameObject prefabsPipe;

    private float time;
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > maxTime)
        {
            Spawn();
            time = 0;
        }

        time += Time.deltaTime;
    }

    private void Spawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-hightRange, hightRange));
        GameObject pipe = Instantiate(prefabsPipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
