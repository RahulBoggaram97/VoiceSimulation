using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public enum startMenuState
{
     Registration,
     PatientFee,
     PatientDetails,
     PatientDetailsPg2,
     NewPatientRegister,
     StartGame,
     Types,
     Roster,
     Settings,
     Models,
     NumsAndAlphabets,
}

public class menuManager : MonoBehaviour
{
    public GameObject Registration;
    public GameObject PatientFee;
    public GameObject PatientDetails;
    public GameObject PatientDetailsPg2;
    public GameObject NewPatientRegister;
    public GameObject StartGame;
    public GameObject Types;
    public GameObject Roster;
    public GameObject Settings;
    public GameObject Models;
    public GameObject NumsAndAlphabets;

    public static menuManager instance;
    public static startMenuState state;
    public static event Action<startMenuState> onMenuStateChanged;
  

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void updatestartMenuState(startMenuState newState)
    {
        state = newState;

        switch (state)
        {
            case startMenuState.Registration:
                 handleRegistrationState();
                 break;

            case startMenuState.PatientFee:
                handlePatientFeeState();
                break;

            case startMenuState.PatientDetails:
                handlePatientDetailsState();
                break;

            case startMenuState.PatientDetailsPg2:
                handlePatientDetailsPg2State();
                break;

            case startMenuState.NewPatientRegister:
                handleNewPatientRegisterState();
                break;


            case startMenuState.StartGame:
                handleStartGameState();
                break;


            case startMenuState.Types:
                handleTypesState();
                break;

            case startMenuState.Roster:
                handleRosterState();
                break;

            case startMenuState.Settings:
                handleSettingsState();
                break;

            case startMenuState.Models:
                handleModelsState();
                break;

            case startMenuState.NumsAndAlphabets:
                handleNumsAndAlphabetsState();
                break;

        }
    }

    private void handleRegistrationState()
    {
        Registration.SetActive(true);
    }
    private void handlePatientFeeState()
    {
        PatientFee.SetActive(false);
    }
    private void handlePatientDetailsState()
    {
        PatientDetails.SetActive(false);
    }
    private void handlePatientDetailsPg2State()
    {
        PatientDetailsPg2.SetActive(false);
    }

    private void handleNewPatientRegisterState()
    {
        NewPatientRegister.SetActive(false);
    }

    private void handleStartGameState()
    {
        StartGame.SetActive(false);
    }

    private void handleTypesState()
    {
        Types.SetActive(false);
    }

    private void handleRosterState()
    {
        Roster.SetActive(false);
    }

    private void handleSettingsState()
    {
        Settings.SetActive(false);
    }

    private void handleModelsState()
    {
        Models.SetActive(false);
    }

    private void handleNumsAndAlphabetsState()
    {
        NumsAndAlphabets.SetActive(false);
    }
}
