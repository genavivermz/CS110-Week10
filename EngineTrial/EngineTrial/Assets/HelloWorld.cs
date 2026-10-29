using UnityEngine;
using Hello World;

public class HelloWorld : MonoBehaviour
{
    private void Start()
    {
        Greeting greeting = new Greeting();
        greeting.Name = "Ari";
        Debug.Log(greeting.BuildMessage());
    }
}