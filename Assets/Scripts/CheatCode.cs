using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCode : MonoBehaviour
{
    //
    private string[] cheatCode;
    private int index;
    private PlayerMovement cheatmoveset;
    private Basic_PM basicmoveset;

    public GameObject originalModel;
    public GameObject motocheat;


    void Start()
    {
        motocheat.SetActive(false);
        basicmoveset = GetComponent<Basic_PM>();
        cheatmoveset = GetComponent<PlayerMovement>();
        cheatCode = new string[] { "g", "o", "d", "m", "o","d"};
        index = 0;
		basicmoveset.enabled = true;
		cheatmoveset.enabled = false;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {

            if (Input.GetKeyDown(cheatCode[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }
        
        if (index == cheatCode.Length)
        {
            basicmoveset.enabled = false;
            cheatmoveset.enabled = true;
            motocheat.SetActive(true);
            originalModel.SetActive(false);
        }
    }
}