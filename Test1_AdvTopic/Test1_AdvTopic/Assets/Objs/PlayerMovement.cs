using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        transform.position = new Vector2(-4.5f, -4.5f);
        animator.SetBool("Move", false);
    }

   
    

    
    void Update()
    {
  

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Move", true);
            animator.SetBool("Up/Down", true);
            commandInterface command = new MoveUp(transform);
            Singleton.Instance.AddMove(command);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Move", true);
            animator.SetBool("Up/Down", false);
            commandInterface command = new MoveDown(transform);
            Singleton.Instance.AddMove(command);
        }
        


        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Move", true);
            animator.SetBool("Left/Right", true);
            commandInterface command = new MoveRight(transform);
            Singleton.Instance.AddMove(command);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Move", true);
            animator.SetBool("Left/Right", false);
            commandInterface command = new MoveLeft(transform);
            Singleton.Instance.AddMove(command);

        }
       
       
        
        if(Input.GetKeyDown(KeyCode.X))
        {
            Singleton.Instance.UndoMove();
        }

        animator.SetBool("Move",false);


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            Debug.Log("Hit");
            Destroy(other.gameObject);
            SceneManager.LoadScene("Win");
        }
        if (other.CompareTag("Finish"))
        {
           
            SceneManager.LoadScene("Loss");
        }
    }


}
