using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAManager : MonoBehaviour
{
    private QANode currentNode;
    
    // Start is called before the first frame update
    void Start()
    {
        currentNode = new QANode();

        currentNode.questionText = "You come to a fork in the road.\n Do you go left or right?";
        currentNode.option1Text = "Left";
        currentNode.option2Text = "Right";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
