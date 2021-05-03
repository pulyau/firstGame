using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public enum team { Team_1, Team_2};
    public team thisTeam = team.Team_1;
    public GameManager gm;
    void Start()
    {
        gm.add(transform.gameObject, thisTeam);
    }
}
