using UnityEngine;

public class LookingAt : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        var cam = Camera.main;
        cam.transform.LookAt(player.transform.localPosition);
    }
}