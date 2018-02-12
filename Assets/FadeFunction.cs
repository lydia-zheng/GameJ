using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeFunction : MonoBehaviour {

    public Image white;
    public Animator anim;



    public IEnumerator Fading()
    {
        anim.SetBool("fade", true);
        yield return new WaitUntil(() => white.color.a == 1);
        SceneManager.LoadScene(0);
       
    }
}
