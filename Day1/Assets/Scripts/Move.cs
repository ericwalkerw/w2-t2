using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform[] destination;
    public float speed = 5f;

    private int point = 0;
    private void Update()
    {
        if (Vector3.Distance(transform.position, destination[point].position) < 0.1f)
        {
            point = Random.Range(0, destination.Length);
            transform.LookAt(destination[point]);
        }

        MoveToPoint();
    }

    public void MoveToPoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination[point].position, speed * Time.deltaTime);
    }


}