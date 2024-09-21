using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{
    public GameObject[] btnText;
    private bool turn = false;
    public GameObject[] btnObj;
    public GameObject turnText;
    public player [,]board = new player[3, 3];
    private player currentPlayer = player.O;
    public GameObject win;
    void Start()
    {
        for(int i=0;i<9;i++)
        {
            int x = i / 3;
            int y = i % 3;
            board[x, y] = player.none;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClicked(int btNum)
    {
        
        btnObj[btNum].GetComponent<Button>().interactable = false;
        if(turn ==true)
        {
            btnText[btNum].GetComponent<Text>().text = "X";
            //GameWin();
            turnText.GetComponent<Text>().text = "Player 'O' Turn";

            turn = false;
            
        }
        else if(turn==false)
        {
           
            btnText[btNum].GetComponent<Text>().text = "O";
            //GameWin();
            turnText.GetComponent<Text>().text = "Player 'X' Turn";
            turn = true ;
        }

        //GameWin();
    }

    public void ButtonTouched()
    {
        SceneManager.LoadScene(1);
    }   
   
    /*public void GameWin()
    {

        GameHorizontal();
      
        
       
        
    }
*/
   

    /*private void GameHorizontal()
    {
        for (int i = 0; i <=2; i++)
            {
                if (board[i, i - 2] == currentPlayer)
                {
                    win.GetComponent<Text>().text = "You Are Win";
                }
            }
    }*/

    public void GameOver()
    {
        for (int i=0;i>btnText.Length;i++)
        {
            
            btnText[i].GetComponent<Button>().interactable = false;
        }
        win.GetComponent<Text>().text = "YouWin";
    }
    public enum player
    {
        none,
        X,
        O
    }

}

