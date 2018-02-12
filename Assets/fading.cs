using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour {
    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000; // negative means render on top (since last)

    private float alpha = 1.0f;
    private int fadeDir = -1; // 1 = fadeout, -1 is fade in;
                              // Use this for initialization
    void onGUI() {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture ); //cover the entire screen with texture

	}
	
    public float BeginFade(int dir)
    {
        fadeDir = dir;
        return (fadeSpeed); //return fadeSpeed so it's easy to time the Application.LoadLevel();
    }

   /* void OnLevelWasLoaded()
    {
        //alpha = 1;
        BeginFade(-1);
    }
    */
}
