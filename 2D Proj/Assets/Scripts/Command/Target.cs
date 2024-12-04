using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : Subject
{
    public GameObject _target;
    private bool _hover;
    private bool _bHover;
    private GameObject _duck;
    private GameObject _bDuck;
    public DuckDisplay display;

    
    public Invoker _invoker;
    
    // Start is called before the first frame update
    void Start()
    {
        Attach(display);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDisable()
    {
        Detach(display);
    }
    public void MoveUp()
    {
        _target.transform.position += Vector3.up;
    }
    public void MoveDown()
    {
        _target.transform.position += Vector3.down;
    }
    public void MoveLeft()
    {
        _target.transform.position += Vector3.left;
    }
    public void MoveRight()
    {
        _target.transform.position += Vector3.right;
    }
    
    public void Shoot()
    {
        if (_hover)
        {
            Destroy(_duck);
            // add points 
            NotifyObservers();
        }
        if (_bHover)
        {
            Destroy(_bDuck);
            StartCoroutine("BadHit");
            //_invoker.reversed = false;
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Duck")
        {
            _hover = true;
            _duck = other.gameObject;
            Debug.Log("Duck Hit"); 
        }
        if (other.tag == "Decoy")
        {
            _bHover = true;
            _bDuck = other.gameObject;
            Debug.Log("Decoy Hit"); 
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Duck")
        {
            _hover = false;
            
            Debug.Log("Decoy lost"); 
        }
        
        if (other.tag == "Decoy")
        {
            _bHover = false;
            
            Debug.Log("Decoy lost"); 
        }

        _hover = false;
        Debug.Log("Duck Loss");
    }
    
    IEnumerator BadHit()
    {
        _invoker.reversed = true;
        Debug.Log("Rev Start: ");
        Debug.Log(_invoker.reversed);
        
        yield return new WaitForSeconds(3);
        _invoker.reversed = false;
        Debug.Log("Rev Done:  ");
        Debug.Log(_invoker.reversed);
        yield return new WaitForSeconds(3);
        
    }
    
    

}
