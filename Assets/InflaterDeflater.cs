using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflaterDeflater : MonoBehaviour
{
    enum Direction
    {
        Inflate,
        Deflate
    }

    private Direction currentDirection = Direction.Inflate;
    public int TickAmount = 500;
    public float inflateAmount = 1.0f;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = TickAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter==0){
            if(currentDirection == Direction.Inflate){
                currentDirection = Direction.Deflate;
            }else{
                currentDirection = Direction.Inflate;
            }
            counter = TickAmount;
        }

        if(currentDirection == Direction.Inflate){
            transform.localScale += inflateAmount * new Vector3(1.0f,1.0f,0) * Time.deltaTime;
        }else{
            transform.localScale -= inflateAmount * new Vector3(1.0f,1.0f,0) * Time.deltaTime;
        }

        counter--;
    }
}
