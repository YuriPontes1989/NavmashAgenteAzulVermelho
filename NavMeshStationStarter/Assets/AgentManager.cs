using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    // Use this for initialization
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
        // a variavel agente vai  achar os gameobject com a tag definada como "ia"
    }
    // Update is called once per frame
    void Update()
    {
        // se eu apertar o botão esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // se o raio, com origem na posição do mouse, cruza com um colisor na distância máxima de 100
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
            // para cada objeto em A coloque o destino do componente Aicontrol como o ponto mouse
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
