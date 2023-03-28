using System.Collections;
using System.Collections.Generic;
using System;
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
    float OscillateSpeed = 5.0f;

    [SerializeField]
    int OscillateLeftTickAmount = 300;

    [SerializeField]
    int OscillateRightTickAmount = 300;

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

    float scale(float m){
        if(direction==Direction.Left){
            return (m/(OscillateLeftTickAmount))*((float)Math.PI);
        }
        else{
            return (m/(OscillateRightTickAmount))*((float)Math.PI);
        }
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
    
        float speed = (float)Math.Sin(scale(counter)) * OscillateSpeed;

        if(direction==Direction.Left){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else{
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        counter--;
    }
}
