using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetScript : MonoBehaviour
{
    [Header("Power")]
    [Tooltip("The power of the planet, default: 0")]
    public int units = 0;
    [Tooltip("The amount of units added, default: 1")]
    public int incrementPower = 1;
    [Tooltip("How long to wait before adding units in seconds"), Range(.1f, 2f)]
    public float delayAmount = 1f;

    [Header("References")]
    public TMP_Text unitText;
    public GameObject shipPrefab;
    public Transform shipSpawnPos;

    private float timer;
    private GameObject ship1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // update unitText
        unitText.text = units.ToString();

        // add units over time
        timer += Time.deltaTime;
        if(timer >= delayAmount)
        {
            timer = 0f;
            units += incrementPower;
        }

    }

    private void OnMouseDown()
    {

    }

    private void OnMouseUp()
    {

    }
}
