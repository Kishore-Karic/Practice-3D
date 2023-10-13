using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortandUnique : MonoBehaviour
{
    [SerializeField] private List<int> value;

    void Awake()
    {
        HashSet<int> uniqueSet = new HashSet<int>();
        Dictionary<int, int> uniqueDictionary = new Dictionary<int, int>();

        for(int i = 0; i < value.Count; i++)
        {
            uniqueSet.Add(value[i]);
        }

        for(int i = 0; i < value.Count; i++)
        {
            int temp = 0;
            if(uniqueDictionary.TryGetValue(value[i], out temp))
            {
                if(temp == 0)
                {
                    temp = 1;
                    uniqueDictionary[value[i]] = temp;
                }
            }
            else
            {
                uniqueDictionary.Add(value[i], 0);
            }
        }

        foreach(var val in uniqueSet)
        {
            Debug.Log(val);
        }

        Debug.Log("Size: " + uniqueDictionary.Count);

        foreach (var val in uniqueDictionary)
        {
            Debug.Log(val.Key + " " + val.Value);
        }

        List<int> uniqueValue = new List<int>(uniqueDictionary.Keys);

        Debug.Log("Old Value");
        for(int i = 0; i < value.Count; i++)
        {
            Debug.Log("Old Value: " + value[i]);
        }

        value.Clear();
        value.AddRange(uniqueValue);

        Debug.Log("Unique Value");
        for (int i = 0; i < value.Count; i++)
        {
            Debug.Log("Unique Value: " + value[i]);
        }

        value.Sort();

        Debug.Log("Sorted Value");
        for (int i = 0; i < value.Count; i++)
        {
            Debug.Log("Sorted Value: " + value[i]);
        }
    }
}
