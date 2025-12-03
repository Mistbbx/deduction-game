using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voting : MonoBehaviour
{
    public static int[] executionerVotes = new int[8];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void voteFor1()
    {
        executionerVotes[0]++;
    }

    void voteFor2()
    {
        executionerVotes[1]++;
    }
    void voteFor3()
    {
        executionerVotes[2]++;
    }
    void voteFor4()
    {
        executionerVotes[3]++;
    }
    void voteFor5()
    {
        executionerVotes[4]++;
    }
    void voteFor6()
    {
        executionerVotes[5]++;
    }
    void voteFor7()
    {
        executionerVotes[6]++;
    }
    void voteFor8()
    {
        executionerVotes[7]++;
    }
}
