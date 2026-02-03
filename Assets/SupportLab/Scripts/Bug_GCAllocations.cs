using UnityEngine;
public class Bug_GCAllocations : MonoBehaviour
{

    private int[] numbers;

    private int evenCount;
    private float logTimer;

    void Start()
    {
        numbers = new int[10000];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = i;
    }

    void Update()
    {

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((numbers[i] & 1) == 0)
                evenCount++;
        }

        logTimer += Time.deltaTime;
        if (logTimer >= 1f)
        {
            logTimer = 0f;
            Debug.Log($"Evens: {evenCount}");
        }
    }
}
