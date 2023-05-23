using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Cat;
    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        key_move();
     }

     public void key_move()
      {
        if (Input.GetKey("w"))
        {
            Cat.transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            Cat.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            Cat.transform.Translate(Vector3.forward * -speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            Cat.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
      }
}
