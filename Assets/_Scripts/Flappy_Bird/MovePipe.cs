using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float SpeedMove = 1.5f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * SpeedMove * Time.deltaTime;
    }
}
