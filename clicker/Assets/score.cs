using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score = 0;
    public Text Scoretext;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void scoreUp()
    {
        Score += 1;
        Scoretext.text = Score.ToString();

    }
    
}
