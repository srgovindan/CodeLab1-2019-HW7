using System.Collections;
using System.Collections.Generic;

public class QANode
{
    public int pageNumber;
    public string questionText;
    public string option1Text;
    public string option2Text;

    public QANode() //default constructor is empty
    {
        pageNumber = 0;
        questionText = "This is default question text. ?";
        option1Text = "??";
        option2Text = "!!";
    }

    public QANode(int pageNumber, string questionText) // you can have ANY number of constructors for a function!!!
    {
        this.pageNumber = pageNumber;
        this.questionText = questionText;
    }

    public QANode(int pageNumber, string questionText,string option1Text, string option2Text)
    {
        this.pageNumber = pageNumber;
        this.questionText = questionText;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
    }
}
