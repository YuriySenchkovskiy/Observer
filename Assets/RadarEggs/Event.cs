using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEvent", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> elisteners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        elisteners.Add(listener);
    }

    public void UnRegister(EventListener listener)
    {
        elisteners.Remove(listener);
    }

    public void Occurred(GameObject go)
    {
        for (int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i]?.OnEventOccurs(go);
        }
    }
}
