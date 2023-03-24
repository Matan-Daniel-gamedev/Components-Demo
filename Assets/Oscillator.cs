using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction
{
    Left,
    Right
}

public class Oscillator : MonoBehaviour
{
    // [SerializeField]
    Vector3 speed = new Vector3(0, 0, 0);

    [SerializeField]
    float OscillateSpeed = 1.0f;

    [SerializeField]
    int OscillateLeftTickAmount = 5;

    [SerializeField]
    int OscillateRightTickAmount = 5;

    [SerializeField]
    Direction StartingDirection = Direction.Left;
    Direction direction = Direction.Left;

    int counter=0;
    float currentSpeed=1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if(StartingDirection==Direction.Left){
            counter=OscillateLeftTickAmount;
        }
        else{
            counter=OscillateRightTickAmount;
        }
        direction = StartingDirection;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 0){
            if(direction==Direction.Left){
                direction=Direction.Right;
                counter=OscillateRightTickAmount;
            }
            else{
                direction=Direction.Left;
                counter=OscillateLeftTickAmount;
            }
        }

        if(direction==Direction.Left){
            transform.Translate(Vector3.left * OscillateSpeed * Time.deltaTime);
        }
        else{
            transform.Translate(Vector3.right * OscillateSpeed * Time.deltaTime);
        }

        counter--;
    }
}
