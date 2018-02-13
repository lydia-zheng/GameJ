using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeFunction : MonoBehaviour
{

    public Image white;
    public Animator anim;
    public DialogueManager dm;
    public bool set = false;
    public bool isLoading = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    /*
    public IEnumerator Fading()
    {
        anim.SetBool("fade", true);
        yield return new WaitUntil(() => white.color.a == 1);
        SceneManager.LoadScene(0);
       
    }
    */

    void Update()
    {

        if (dm.currNPC == "LastSceneDialogue" && dm.currentLine == 5)
        {
            if (!set)
            {
                anim.SetBool("fade", true);
                set = true;
            }

            

                             if(white.color.a == 1)
                              {
                                   if (!isLoading)
                                   {
                                   SceneManager.LoadScene(0);
                                       isLoading = true;
                                   }

                              }
                    

        }
    }
}
