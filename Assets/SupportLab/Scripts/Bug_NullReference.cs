using UnityEngine;

public class Bug_NullReference : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
      target.transform.position = Vector3.zero;
    }

}
