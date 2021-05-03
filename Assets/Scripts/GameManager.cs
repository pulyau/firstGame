using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LinkedList<GameObject> team1;
    public LinkedList<GameObject> team2;
    // Start is called before the first frame update
    void Awake()
    {
        team1 = new LinkedList<GameObject>();
        team2 = new LinkedList<GameObject>();
    }

    // Update is called once per frame
    public void add(GameObject toAdd, Team.team addTeam)
    {
        if (addTeam == Team.team.Team_1)
        {
            team1.AddLast(toAdd);
        }
        else
        {
            team2.AddLast(toAdd);
        }
    }

    public LinkedList<GameObject> GetList(Team.team teamToReturn)
    {
        if (teamToReturn == Team.team.Team_1) return team1;
        else return team2;
    }
}
