using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    
    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }
    
    
    
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        // Instantiate at zero, increment, once it hits the number of items in the list, it will reset.
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }
    }
    
    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        // Instantiate from a random range, (min, max)
        num = Random.Range(0, obj.vector3List.Count);
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);

    }
}
