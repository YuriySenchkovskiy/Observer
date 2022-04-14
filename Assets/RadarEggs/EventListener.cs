using System;
using UnityEngine.Events;
using UnityEngine;

[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<GameObject> {}
public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.UnRegister(this);
    }

    public void OnEventOccurs(GameObject gameObject)
    {
        response?.Invoke(gameObject);
    }
}
