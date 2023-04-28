using UnityEngine;

public class FollowCat : MonoBehaviour
{
    public Transform cat;//Transform can get object position
    public Vector3 offset;//Vector3 can storge x,y,z value

    // Update is called once per frame
    void Update()
    {
        transform.position = cat.position + offset;
    }
}
