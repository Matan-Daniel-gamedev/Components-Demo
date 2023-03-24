using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HideShow : MonoBehaviour
{

    bool isHidden = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            gameObject.GetComponent<Renderer>().enabled = isHidden;
            isHidden = !isHidden;

            // if(isHidden){
            //     gameObject.SetActive(true);
            //     isHidden=false;
            // }else{
            //     gameObject.SetActive(false);
            //     isHidden=true;
            // }
            
        }
    }
}
