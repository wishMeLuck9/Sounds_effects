using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - 50)
        {
            transform.position = startPosition;
        }
    }
}
