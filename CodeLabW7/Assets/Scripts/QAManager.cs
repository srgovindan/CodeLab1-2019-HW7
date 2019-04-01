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
        string fileLocation = Application.dataPath + "/QAPage"+1+".json";    
        //WriteNewJson(fileLocation); //This was to initially build our Json file, use this if it gets deleted
        ReadFromJson(fileLocation);
        UpdateUI(currentNode);   
    }

    void WriteNewJson(string fileLocation)
    {     
        currentNode = new QANode(
            1,
            "You come to a fork in the road.\n Do you go left or right?",
            "Left",
            "Right");
        string jsonStr = JsonUtility.ToJson(currentNode,true);
        print(jsonStr);
        File.WriteAllText(fileLocation,jsonStr);
        
        //pretty printing kills mobile data quotas
        
//        currentNode.pageNumber = 1;
//        currentNode.questionText = "You come to a fork in the road.\n Do you go left or right?";
//        currentNode.option1Text = "Left";
//        currentNode.option2Text = "Right";

    }

    public void ChooseOption(int pageNumber)
    {
        string fileLocation= Application.dataPath + "/QAPage" + currentNode.option1Page + ".json";
        if (pageNumber != 1)
        {
            fileLocation= Application.dataPath + "/QAPage" + currentNode.option2Page + ".json";
        }
        ReadFromJson(fileLocation);
        UpdateUI(currentNode);
    }
    
    void ReadFromJson(string fileLocation)
    {
        string input = File.ReadAllText(fileLocation);
        currentNode = JsonUtility.FromJson<QANode>(input);
    }

    void UpdateUI(QANode node)
    {
        questionText.text = node.questionText;
        option1Text.text = node.option1Text;
        option2Text.text = node.option2Text;
    }
}