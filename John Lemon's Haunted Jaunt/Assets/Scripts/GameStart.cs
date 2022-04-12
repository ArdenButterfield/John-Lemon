using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject player;
    public GameObject entranceText;

    bool m_IsPlayerAtEntrance;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtEntrance = true;
            ShowEntranceText();
        }
    }

    void Update()
    {
        if (m_IsPlayerAtEntrance)
        {
            m_Timer += Time.deltaTime;
        }

        if (m_Timer > 2)
        {
            entranceText.SetActive(false);
            m_IsPlayerAtEntrance = false;
            m_Timer = 0;
        }
    }

    void ShowEntranceText()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 toOther = player.transform.position - transform.position;

        if (Vector3.Dot(forward, toOther) < 0)
        {
            entranceText.SetActive(true);
        }
    }
}
