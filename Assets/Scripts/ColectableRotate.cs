using UnityEngine;

public class ColectableRotate : MonoBehaviour
{
    [SerializeField] int rotateSpeed = 1;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
