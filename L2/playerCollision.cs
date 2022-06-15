using UnityEngine;

public class playerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo )
    {
         Debug.Log(collisionInfo.collider.tag);
        if(collisionInfo.collider.tag =="obstracle")
        {
            Debug.Log("we hit an obstacle");
        }
    }
}
