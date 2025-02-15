using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    private FallTrigger[] pins;

    private void Start()
    {
        //find all FallTrigger objects
        pins = FindObjectsByType<FallTrigger>((FindObjectsSortMode)FindObjectsInactive.Include);

        foreach (FallTrigger pin in pins)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }

    private void IncrementScore()
    {
        score++;
    }
}
