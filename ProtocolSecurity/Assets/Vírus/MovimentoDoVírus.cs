using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimentoDoVírus : MonoBehaviour
{
    public NavMeshAgent virus;
    public Transform Jogador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        virus.SetDestination(Jogador.position);
    }
}
