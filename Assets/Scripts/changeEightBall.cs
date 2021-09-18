using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeEightBall : MonoBehaviour
{
    public GameObject eightBallTextObject;
    string [] responses = {
        // Positive
        "It is certain",
        "It is decidedly so",
        "Without a doubt",
        "Yes definitely",
        "You may rely on it",
        "As I see it, yes.",
        "Most likely",
        "Outlook good",
        "Yes",
        "Signs point to yes",
        // Unclear
        "Reply hazy, try again",
        "Ask again later",
        "Better not tell you now",        
        "Cannot predict now",
        "Concentrate and ask again",
        // Negative
        "Don't count on it",        
        "Don't count on it",
        "My sources say no",
        "Outlook not so good",
        "Very doubtful"
        };


         static System.Random random = new System.Random(); 
         int randomResponse = random.Next(19);

    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("Update", 0f, 10f);   
    }

    // Update is called once per frame
    void Update()
    {    
         eightBallTextObject.GetComponent<TextMeshPro>().text = responses[randomResponse];   
    }
}
