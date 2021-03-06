using UnityEngine;

public class ShowWhenClose : MonoBehaviour
{
    // public gameobject
    public GameObject other;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        // check the distance between this object and the gameobject
        if (Vector3.Distance(transform.position, other.transform.position) < 10)
            // show the gameobject
            other.SetActive(true);
        else
            // hide the gameobject
            other.SetActive(false);
    }
}