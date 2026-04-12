using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour
{
    public GameObject backgroundPref;
    public float speed;
    public int count;
    public float distance;
    public float distanceToRotate;
    // Start is called before the first frame update

    List<GameObject> backgrounds = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            SpawnBackground(new Vector3(0, distance * i, 0));
        }
    }

     private void FixedUpdate ()
    {
        Shift();
        CheckForrotate();
    }

    private void CheckForrotate()
    {
        float minY = float.MaxValue;
        GameObject lowestBig = null;

        foreach (GameObject bg in backgrounds) 
        {
            if (bg.transform.position.y < minY) 
            {
                minY = bg.transform.position.y;
                lowestBig = bg;
            }

        }
        if (minY <= -distanceToRotate)
        
            {
            RotateBackground(lowestBig);
            }
    }

    private void RotateBackground(GameObject bgToRotate)
    {
        float maxY = float.MinValue;

        foreach (GameObject bg in backgrounds)
        {
            if (bg.transform.position.y > maxY)
            {
                maxY = bg.transform.position.y;
            }
        }
        Vector2 pos = bgToRotate.transform.position;
        pos.y = maxY + distance;
        bgToRotate.transform.position = pos;
    }

    private void SpawnBackground(Vector3 pos)
    {
        GameObject bg = Instantiate(backgroundPref, pos, Quaternion.identity);
        backgrounds.Add(bg);
    }

    private void Shift()
    {
        foreach (GameObject bg in backgrounds)
        {
            Vector2 pos = bg.transform.position;
            pos.y -= speed * Time.fixedDeltaTime;

            bg.transform.position = pos;
        }
    }

   
}
