using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    Rigidbody2D animal;
    public int nextMove_x;
    public int nextMove_y;

    // Start is called before the first frame update
    void Awake()
    {
        animal = GetComponent<Rigidbody2D>();

        Invoke("Think", 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animal.velocity = new Vector2(nextMove_x, nextMove_y);

        Vector2 limitarea = new Vector2(animal.position.x + nextMove_x, animal.position.y + nextMove_y);
        Debug.DrawRay(limitarea, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(limitarea, Vector3.down, 1, LayerMask.GetMask("Panel"));
        if (rayHit.collider == null) {
            //if(rayHit.distance)
            CancelInvoke();
            //Invoke("Think", 3);
        }
        else
        {
            Invoke("Think", 3);
        }
    }

    void Think()
    {
        nextMove_x = Random.Range(-30, 30);
        nextMove_y = Random.Range(-30, 30);
        Invoke("Think", 3);
    }
}
