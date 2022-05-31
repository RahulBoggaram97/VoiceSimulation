using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;
using System.Text;
using TMPro;
using System;

public class wordsEnable : MonoBehaviour
{
    public string[] wordToBeRecognised;

    public GameObject ball;

    public TextMeshPro wordText;

    private KeywordRecognizer m_Recognizer;

    void Start()
    {
        m_Recognizer = new KeywordRecognizer(wordToBeRecognised);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        wordText.text = wordToBeRecognised[0];
        m_Recognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());

        if (ball.activeInHierarchy == true)
            ball.SetActive(false);
        else
            ball.SetActive(true);
       //gameObject.SetActive(true); 
    }
}
