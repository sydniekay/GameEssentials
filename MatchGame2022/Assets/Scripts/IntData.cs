using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void ReplaceValue(int number)
    {
        value = number;
    }

}
