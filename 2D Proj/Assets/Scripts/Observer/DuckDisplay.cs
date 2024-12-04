using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckDisplay : Observer
{
    public Text Score;
    public int count;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Notify(Subject subject)
    {
        count++;
        Score.text = count.ToString();
        
    }
    
}
