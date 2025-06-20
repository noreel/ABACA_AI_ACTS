using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    [SerializeField]NavMeshAgent agent;
     Camera cam;
    void Start()
    {
        cam = FindObjectOfType<Camera>();
        //agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 location = new Vector3(hit.point.x, 0, hit.point.z);
                agent.SetDestination(location);
            }
        }
    }
}