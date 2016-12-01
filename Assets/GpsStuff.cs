using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GpsStuff : MonoBehaviour
{
    public Text text;

    // Use this for initialization
    void Start()
    {
        Input.location.Start(1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Input.location.lastData.latitude + " " + Input.location.lastData.longitude;
    }
}
