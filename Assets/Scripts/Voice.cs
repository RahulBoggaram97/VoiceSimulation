using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;

public class Voice : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    Animator anim;
    void Start()
    {
        actions.Add("GAS", Forward);
        //actions.Add("next", Up);
        actions.Add("CHARCOAL", Down);
        //actions.Add("back", Back);


        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();

        anim = GetComponent<Animator>();
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    public void Forward()
    {
        transform.Translate(-4.7f, 6.3f, 0);
        //anim.SetBool("trainMove", true);
    }

    public void Down()
    {
        transform.Translate(-4.98f, 3.6f, 0);
    }

    //private void Up()
    //{
    //    //transform.Translate(0, 1, 0);
    //    animator.Play("move");
    //}

    //private void Back()
    //{
    //    transform.Translate(0, -1, 0);
    //}
}
