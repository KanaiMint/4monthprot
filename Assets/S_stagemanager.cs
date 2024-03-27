using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_stagemanager : MonoBehaviour
{
   public enum State { 
        front,
        back,
        right,
        left,
        nomal
    
    };
   public State state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.front)
        {

        }
    }
}
