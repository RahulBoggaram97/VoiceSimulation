using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Windows.Speech;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using System;

public class theAudioSmaplerNew : MonoBehaviour
{
    public float rmsVal;
    public float dbVal;
    public float pitchVal;

    private const int QSamples = 1024;
    private const float RefValue = 0.1f;
    private const float Threshold = 0.02f;

    public float[] _samples;
    public float[] _spectrum;
    private float _fSample;

    public AudioMixerGroup _audioMixerGroup;

    [SerializeField]
    private string[] m_Keywords;

    private KeywordRecognizer m_Recognizer;

    bool phoneemeRecognised = false;

    public GameObject sprite;


    [Serializable]public class externalEvent: UnityEvent { }

    [FormerlySerializedAs("OnIncresesLoudness")]
    [SerializeField]
    private externalEvent M_OnPitchOrLoudnesRecognised = new externalEvent();




    public externalEvent OnPitchOrLoudnesRecognised
    {
        get { return M_OnPitchOrLoudnesRecognised; }
        set { M_OnPitchOrLoudnesRecognised = value; }
    }

    [Serializable] public class externalEvent2 : UnityEvent { }

    [FormerlySerializedAs("OnNoVolume")]
    [SerializeField]
    private externalEvent2 M_onLoudnesAndPitchStopped = new externalEvent2();




    public externalEvent2 OnLoudnesAndPitchStopped
    {
        get { return M_onLoudnesAndPitchStopped; }
        set { M_onLoudnesAndPitchStopped = value; }
    }

    private void Start()
    {

        // Create audio source
        var audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.bypassEffects =
        audioSource.bypassListenerEffects = false;
        // Start microphone
        audioSource.clip = Microphone.Start(null, true, 10, AudioSettings.outputSampleRate);
        audioSource.outputAudioMixerGroup = _audioMixerGroup;
        audioSource.Play();




        _samples = new float[QSamples];
        _spectrum = new float[QSamples];
        _fSample = AudioSettings.outputSampleRate;


        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();



    }

    //void OnAudioFilterRead(float[] data, int channels) { }


    void Update()
    {
        AnalyzeSound();

        //Debug.Log("RMS: " + rmsVal.ToString("F2"));
        //Debug.Log(dbVal.ToString("F1") + " dB");
        //Debug.Log(pitchVal.ToString("F0") + " Hz");

        if (phoneemeRecognised)
        {

        }

        if (dbVal > 2f)
        {
            M_OnPitchOrLoudnesRecognised.Invoke();
        }
        if(dbVal < 0f)
        {
            M_onLoudnesAndPitchStopped.Invoke();
        }
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        phoneemeRecognised = true;
        Debug.Log("Word Recognised");

    }

    void AnalyzeSound()
    {
        GetComponent<AudioSource>().GetOutputData(_samples, 0); // fill array with samples
        int i;
        float sum = 0;
        for (i = 0; i < QSamples; i++)
        {
            sum += _samples[i] * _samples[i]; // sum squared samples
        }
        rmsVal = Mathf.Sqrt(sum / QSamples); // rms = square root of average
        dbVal = 20 * Mathf.Log10(rmsVal / RefValue); // calculate dB
        if (dbVal < -160) dbVal = -160; // clamp it to -160dB min
                                        // get sound spectrum
        GetComponent<AudioSource>().GetSpectrumData(_spectrum, 0, FFTWindow.BlackmanHarris);
        float maxV = 0;
        var maxN = 0;
        for (i = 0; i < QSamples; i++)
        { // find max 
            if (!(_spectrum[i] > maxV) || !(_spectrum[i] > Threshold))
                continue;

            maxV = _spectrum[i];
            maxN = i; // maxN is the index of max
        }
        float freqN = maxN; // pass the index to a float variable
        if (maxN > 0 && maxN < QSamples - 1)
        { // interpolate index using neighbours
            var dL = _spectrum[maxN - 1] / _spectrum[maxN];
            var dR = _spectrum[maxN + 1] / _spectrum[maxN];
            freqN += 0.5f * (dR * dR - dL * dL);
        }
        pitchVal = freqN * (_fSample / 2) / QSamples; // convert index to frequency
    }

}

