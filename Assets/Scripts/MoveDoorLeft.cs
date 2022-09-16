using UnityEngine;

public class MoveDoorLeft : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;

    float totalMoveDistance;
    Vector3 startingLocation;

    [SerializeField] GameObject DoorLeft;
    // Start is called before the first frame update
    void Start()
    {
        totalMoveDistance = 2f;
        startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       float distanceTraveled = GetDistanceTraveled();

       if (distanceTraveled < totalMoveDistance){
               gameObject.transform.Translate(moveDirection * moveSpeed);
       }

      // if (distanceTraveled > totalMoveDistance)
    //   {
    //      FlipMoveDirection();
    //    }

   }
//
//    void FlipMoveDirection()
//    {
//      //  moveDirection = -moveDirection;
//    }
//
    float GetDistanceTraveled()
    {
       return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
