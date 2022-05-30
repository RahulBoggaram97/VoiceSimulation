using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using System.Text;
using TMPro;
using UnityEngine.Windows.Speech;


public class voiceRecogniser : MonoBehaviour
{
    [Serializable]
    public class voiceRecogniserEvent : UnityEvent { }

    [FormerlySerializedAs("OnPhraseRecognised")]
    [SerializeField]
    private voiceRecogniserEvent M_onPhraseRecognisedEvent = new voiceRecogniserEvent();


    public voiceRecogniserEvent OnPhrasedRecognisedEventCaller
    {
        get { return M_onPhraseRecognisedEvent; }
        set { M_onPhraseRecognisedEvent = value;}
    }


    public string[] wordToBeRecognised;



    public TextMeshProUGUI wordText;

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

        recogniserExtention(args.text);
    }


    void recogniserExtention(string recgonisedWord)
    {
        Debug.Log("you said " + recgonisedWord);

        

        M_onPhraseRecognisedEvent.Invoke();
    }
}
