using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    // This script will not work without the handler script
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
