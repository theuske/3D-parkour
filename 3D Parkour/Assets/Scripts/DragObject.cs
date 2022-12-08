using UnityEngine;

public class PushBox : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody box;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            box.AddForce(transform.forward * speed);
        }
    }
}