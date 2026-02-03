using System.Collections.Generic;
using UnityEngine;

public class Bug_ManagedMemoryLeak : MonoBehaviour
{
    private static readonly List<byte[]> LeakedData = new List<byte[]>();

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;

            for (int i = 0; i < 50; i++)
                LeakedData.Add(new byte[100_000]); // 5MB/sec

            Debug.Log($"Leaked chunks: {LeakedData.Count}");
        }
    }

    void OnDisable()
    {
        LeakedData.Clear(); 
    }
}
