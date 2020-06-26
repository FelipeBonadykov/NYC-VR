using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public bool isOutside;
    public GameObject player, door, destination, apartment, nyc;
    private Collider colliderOnBehalfOfPlayer, colliderOfTheDoor;
    void Start()
    {
        nyc.gameObject.SetActive(false);
        colliderOnBehalfOfPlayer = player.GetComponent<Collider>();
        colliderOfTheDoor = door.GetComponent<Collider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (colliderOnBehalfOfPlayer.bounds.Intersects(colliderOfTheDoor.bounds))
        {
            if (isOutside)
            {
                nyc.gameObject.SetActive(false);
                apartment.gameObject.SetActive(true);
            }
            else
            {
                nyc.gameObject.SetActive(true);
                apartment.SetActive(false);
            }
            player.transform.position = destination.transform.position;
        }
            
    }
}
