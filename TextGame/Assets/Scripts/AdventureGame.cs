using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    // SerializeField: Makes a PRIVATE field available within the inspector
    // Not needed for public fields
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    // Track current state
    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;

        // Use the text field within the text component (e.g. the story text compoonent we assigned to it via UI)
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for(int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[0];
            }
            
        }

       
        
        textComponent.text = state.GetStateStory();
    }
}
