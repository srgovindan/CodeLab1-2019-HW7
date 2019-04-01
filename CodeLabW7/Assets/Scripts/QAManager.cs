using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class QAManager : MonoBehaviour
{
    public Text questionText;
    public Text option1Text;
    public Text option2Text;
    
    QANode currentNode;
    
    // Start is called before the first frame update
    void Start()
    {
//        currentNode = new QANode(
//            1,
//            "You come to a fork in the road.\n Do you go left or right?",
//            "Left",
//            "Right");
        
//        string jsonStr = JsonUtility.ToJson(currentNode,true);
//        //pretty printing kills mobile data quotas
//        print(jsonStr);
        string fileLocation = Application.dataPath + "/QAData.json";
//        File.WriteAllText(fileLocation,jsonStr);

        string input = File.ReadAllText(fileLocation);
        currentNode = JsonUtility.FromJson<QANode>(input);
        
//        currentNode.pageNumber = 1;
//        currentNode.questionText = "You come to a fork in the road.\n Do you go left or right?";
//        currentNode.option1Text = "Left";
//        currentNode.option2Text = "Right";
        UpdateUI(currentNode);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI(QANode node)
    {
        questionText.text = node.questionText;
        option1Text.text = node.option1Text;
        option2Text.text = node.option2Text;
    }
}
