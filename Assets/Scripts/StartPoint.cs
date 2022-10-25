using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StartPoint : MonoBehaviour
{
    public string uuid; // uuid = universal uniqued identifier
    private PlayerController player;
    [SerializeField] private Vector2 facingDirection;


    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        if (!player.nextUuid.Equals(uuid))
        {
            return;
        }
       
            player.transform.position = transform.position;
            player.lastDirection = facingDirection;

        GameObject confiner = GameObject.Find("Camera Confiner");
        if (confiner != null)
        {
            FindObjectOfType<CinemachineConfiner2D>().m_BoundingShape2D = confiner.GetComponent<PolygonCollider2D>();

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
