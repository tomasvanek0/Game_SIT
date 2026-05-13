using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;


public class JsonScore : MonoBehaviour
{
    string savePath;
    string savePath2;

    public static JsonScore Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        savePath = Application.persistentDataPath + "/level1.json";
        savePath2 = Application.persistentDataPath + "/level2.json";
    }

    public void SaveGame1()
    {
        SaveScore data = new SaveScore();

        data.score = GameManager.Instance.score;
       

        string json = JsonUtility.ToJson(data, true);

        json = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));

        File.WriteAllText(savePath, json);

        Debug.Log("Hra uložena do: " + savePath);
    }
    public float LoadGame1()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            json = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(json));
            Debug.Log(json);
            SaveScore data = JsonUtility.FromJson<SaveScore>(json);

            return data.score;

        }
        else
        {
            Debug.Log("Save soubor neexistuje");
            return 0;
        }
    }
    public void SaveGame2()
    {
        SaveScore data = new SaveScore();

        data.score = GameManager.Instance.score;


        string json = JsonUtility.ToJson(data, true);
        json = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));

        File.WriteAllText(savePath2, json);

        Debug.Log("Hra uložena do: " + savePath2);
    }
    public float LoadGame2()
    {
        if (File.Exists(savePath2))
        {
            string json = File.ReadAllText(savePath2);
            json = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(json));
            SaveScore data = JsonUtility.FromJson<SaveScore>(json);

            return data.score;

        }
        else
        {
            Debug.Log("Save soubor neexistuje");
            return 0;
        }
    }
}

