using Unity.VisualScripting;
using UnityEngine;

public class Objective : MonoBehaviour
{
    [SerializeField] private string objectiveText = "I am an objective!";

    private void OnEnable()
    {
        Debug.Log(objectiveText);
    }
}
