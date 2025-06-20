using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent enemy;          

    void Update()
    {
        if (target != null)
        {
            enemy.SetDestination(target.transform.position);
        }
        else
        {
            Debug.Log("Gotcha beach");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with target. Destroying follower.");
            Destroy(collision.gameObject);

            
        }     

    }
}
