using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Transform timerText;
    public float counter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += 0.01f;
        counter = Mathf.Ceil(counter);
        timerText.GetComponent<Text>().text = "Score: " + counter.ToString();
    }
}
