using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SpawnManager spawnManager;
    public ItemManager itemManager;
    public GameObject Cover;
    public Text BestScoreText;
    public Text ScoreText;
    int score;

    UserData userData;

    void Start()
    {
        EventManager.EnemyDieEvent += OnEnemyDie;
        LoadUserData();
        BestScoreText.text = String.Format("Best Score : {0}", userData.BestScore);
    }

    public void OnClickStartButton()
    {
        Cover.SetActive(false);
        StartCoroutine(spawnManager.SpawnRandom());
        itemManager.SpawnRandom();
    }

    public void OnEnemyDie()
    {
        score++;
        ScoreText.text = String.Format("Score : {0}", score);
        if (userData.BestScore < score)
        {
            userData.BestScore = score;
            BestScoreText.text = String.Format("Best Score : {0}", userData.BestScore);
            SaveUserData();
        }
    }


    void SaveUserData()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/userdata.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, userData);
        file.Close();
    }

    void LoadUserData()
    {
        FileStream file;
        try
        {
            file = new FileStream(Application.persistentDataPath + "/userdata.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            userData = (UserData)bf.Deserialize(file);
            file.Close();
        }
        catch (FileNotFoundException e)
        {
            Debug.Log(e.Message);
            userData = new UserData();
        }
    }
}

[Serializable]
class UserData
{
    public int BestScore;
}



