using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DialogueManager : MonoBehaviour
{
 
    public GameObject dBox;
    public Text dText;
    public Text dName;
    public bool dialogActive;
    public int numberLines;
    public int currentLine = 0;
    public string currNPC;
   
    public bool updated = false;



    GameObject textObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (currNPC == "Mother")
        {
            dName.text = "Mother";
            numberLines = 2;
            if (currentLine == 0)
            {
                dText.text = "My child...";
            }
            else if (currentLine == 1)
            {
                dText.text = "I lost everything in one day.";
            }
        }
        else if (currNPC == "Bag")
        {
            dName.text = "Old Bag";
            numberLines = 2;
            if (currentLine == 0)
            {
                dText.text = "<i>Mom's favorite bag.</i>";
            }
            else if (currentLine == 1)
            {
                dText.text = "<i>The day she lost it, she was distraught.</i>";

            }
        }
        else if (currNPC == "Police")
        {
            dName.text = "Police";
            numberLines = 3;
            if (currentLine == 0)
            {
                dText.text = "Hey you!";
            }
            else if (currentLine == 1)
            {
                dText.text = "Why are you still wandering around at this time of night?";
            }
            else if (currentLine == 2)
            {
                dText.text = "You better not be up to anything...";
            }
        }
        else if (currNPC == "Doge")
        {
            dName.text = "Developers";
            numberLines = 2;
            if (currentLine == 0)
            {
                dText.text = "much unity";
            }
            else if (currentLine == 1)
            {
                dText.text = "very suffer";
            }
        }
        else if (currNPC == "Crayon")
        {
            dName.text = "Red Crayon";
            numberLines = 3;
            if (currentLine == 0)
            {
                dText.text = "<i>A fond childhood memory.</i>";
            }
            else if (currentLine == 1)
            {
                dText.text = "<i>I used to fight over the red crayon with my sister.</i>";
            }
            else if (currentLine == 2)
            {
                dText.text = "<i>We both loved red.</i>";
            }
        }
        else if (currNPC == "Letter")
        {
            dName.text = "Love Letter";
            numberLines = 2;
            if (currentLine == 0)
            {
                dText.text = "<i>My sister's admirer sent these everyday.</i>";
            }
            else if (currentLine == 1)
            {
                dText.text = "<i>These stopped coming a week before she died.</i>";
            }
        }
        else if (currNPC == "Sister")
        {
            dName.text = "Sister";
            numberLines = 3;
            if (currentLine == 0)
            {
                dText.text = "I see you've come to visit me.";
            }
            else if (currentLine == 1)
            {
                dText.text = "I am so sorry for what happened...";
            }
            else if (currentLine == 2)
            {
                dText.text = "But I'll be seeing you soon. Let's talk lots then.";
            }
        }
        else if (currNPC == "Detective")
        {
            dName.text = "Detective";
            numberLines = 2;
            if (currentLine == 0)
            {
                dText.text = "Sorry Kiddo,";
            }
            else if (currentLine == 1)
            {
                dText.text = "there's nothing I can do to prove your innocence.";
            }
        }

        else if (currNPC == "Scarf")
        {
            dName.text = "Scarf";
            numberLines = 2;
            if (currentLine == 0)
            {
                dText.text = "<i>My sister used to tell me to wear a scarf before going out.</i>";
            }
            else if (currentLine == 1)
            {
                dText.text = "<i>I never did.</i>";
            }

        }

		else if (currNPC == "FirstSceneDialogue")
		{
			dName.text = "Me";
			numberLines = 2;
			if (currentLine == 0)
			{
				dText.text = "<i>Tonight is my last night of sleep.</i>";
			}
			else if (currentLine == 1)
			{
				dText.text = "<i>...not that I care anymore.</i>";
			}
		}
		else if (currNPC == "DarkSceneDialogue")
		{
			dName.text = "Me";
			numberLines = 3;
			if (currentLine == 0)
			{
				dText.text = "<i>...sister?</i>";
			}
			else if (currentLine == 1)
			{
				dText.text = "<i>Who is that inside the house with her...</i>";
			}
			else if (currentLine == 2)
			{
				dText.text = "<i>Wait... </i>";
			}
		}

        else if (currNPC == "LastSceneDialogue")
        {
            
            numberLines = 6;
            if(currentLine == 0)
            {
                dName.text = "Police";
                dText.text = "Ahem!";
            }
            if (currentLine == 1)
            {
                dName.text = "Police";
                dText.text = " Come on, prisoner. It's time.";
            }
            if (currentLine == 2)
            {
                dName.text = "Me";
                dText.text = "......";
            }

            if (currentLine == 3)
            {
                dName.text = "Me";
                dText.text = "Give me a moment.";
            }
            if(currentLine == 4)
            {
                dName.text = "Me";
                dText.text = "(I'll see you soon, sis.)";
            }
            if(currentLine == 5)
            {
                Destroy(dBox);
                Image image = FindObjectOfType<Image>();
                if (!updated)
                {
                    updated = true;
                    image.GetComponent<FadeFunction>();
                    
                }
               


           
            }
            //fade out would be great here
  


        }
       
        


        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dBox.SetActive (false);
            //dialogActive = false;
            currentLine++;
        }

        if (currentLine >= numberLines)
        {
            dBox.SetActive(false);
            dialogActive = false;
            currentLine = 0;

            if (currNPC == "Bag")
            {
                GameObject shard = GameObject.Find("Bag");
                if (shard != null)
                {
                    shard.GetComponent<Shard>().DestroyShard();
                }
            }
            else if (currNPC == "Crayon")
            {
                GameObject shard = GameObject.Find("Crayon");
                if (shard != null)
                {
                    shard.GetComponent<Shard>().DestroyShard();
                }
            }
            else if (currNPC == "Letter")
            {
                GameObject shard = GameObject.Find("Letter");
                if (shard != null)
                {
                    shard.GetComponent<Shard>().DestroyShard();
                }
            }

            else if (currNPC == "Scarf")
             {
                 GameObject shard = GameObject.Find("Scarf");
                 if (shard != null)
                 {
                     shard.GetComponent<Shard>().DestroyShard();
                 }
             }
           
            

        }

    }

    //public void displayBox(string name, string dialogue){
    public void displayBox()
    {
        dialogActive = true;
        dBox.SetActive(true);
    }

   
   
}
