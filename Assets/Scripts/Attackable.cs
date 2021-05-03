using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//who can attack
public class Attackable : MonoBehaviour
{
    GameObject currentTarget;
    public float speed = 2f;
    public GameManager gm;
    Team.team teamToAttack;
    LinkedList<GameObject> thingsToAttack;

    private void Start()
    {
        if (this.GetComponent<Team>().thisTeam == Team.team.Team_1) teamToAttack = Team.team.Team_2;
        else teamToAttack = Team.team.Team_1;
        thingsToAttack = gm.GetList(teamToAttack);
    }

    // Update is called once per frame
    void Update()
    {
        currentTarget = setTarget();

        transform.position += Vector3.Normalize((currentTarget.transform.position - transform.position)) * (speed * Time.deltaTime);
    }

    private GameObject setTarget()
    {
        GameObject toAttack = currentTarget;
        if (currentTarget == null) currentTarget = thingsToAttack.First.Value;
        foreach( GameObject enemy in thingsToAttack){
            if (compareEnemies(enemy, toAttack)){
                toAttack = enemy;
            }
        }
        return toAttack;
    }

    private bool compareEnemies(GameObject enemy1, GameObject enemy2)
    {
        float dist1 = Vector3.Distance(enemy1.transform.position, transform.position);
        float dist2 = Vector3.Distance(enemy2.transform.position, transform.position);

        if (dist1 < dist2) return true;
        else return false;

    }
}
