using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadCont : Obstacle
{
   public override void Move()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = newPosition.x - speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
