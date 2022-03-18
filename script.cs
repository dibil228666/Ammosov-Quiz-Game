using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{

    public QuestionList[] questions;
    public Text quest;

    List<object> qList;

    public void OnClickPlay()
    {
        quest.text = questions[Random.Range(0, questions.Length)].question;
    }

}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[4];
}