using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private string playerName;
    void Start()
    {
        Debug.Log(playerName);
    }
}
