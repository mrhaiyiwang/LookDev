using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dev : MonoBehaviour
{
    float sensitivity = 0.8f;
    float lastMetalness = 0;
    float lastRoughness = 0;
    // Update is called once per frame
    void Update()
    {
        // attached to a game object
        // if up/down arrow keys are pressed, change the metallic value of the material
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastMetalness = GetComponent<Renderer>().material.GetFloat("_Metalness");
        }
        if (Input.GetKey(KeyCode.W))
        {
            float newMetalness = lastMetalness + sensitivity*Time.deltaTime;
            // Clamp the value between 0 and 1
            newMetalness = Mathf.Clamp(newMetalness, 0, 1);
            GetComponent<Renderer>().material.SetFloat("_Metalness", newMetalness);
            lastMetalness = newMetalness;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            lastMetalness = GetComponent<Renderer>().material.GetFloat("_Metalness");
        }
        if (Input.GetKey(KeyCode.S))
        {
            float newMetalness = lastMetalness - sensitivity*Time.deltaTime;
            // Clamp the value between 0 and 1
            newMetalness = Mathf.Clamp(newMetalness, 0, 1);
            GetComponent<Renderer>().material.SetFloat("_Metalness", newMetalness);
            lastMetalness = newMetalness;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            lastRoughness = GetComponent<Renderer>().material.GetFloat("_Roughness");
        }
        if (Input.GetKey(KeyCode.D))
        {
            float newRoughness = lastRoughness + sensitivity*Time.deltaTime;
            // Clamp the value between 0 and 1
            newRoughness = Mathf.Clamp(newRoughness, 0, 1);
            GetComponent<Renderer>().material.SetFloat("_Roughness", newRoughness);
            lastRoughness = newRoughness;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            lastRoughness = GetComponent<Renderer>().material.GetFloat("_Roughness");
        }
        if (Input.GetKey(KeyCode.A))
        {
            float newRoughness = lastRoughness - sensitivity*Time.deltaTime;
            // Clamp the value between 0 and 1
            newRoughness = Mathf.Clamp(newRoughness, 0, 1);
            GetComponent<Renderer>().material.SetFloat("_Roughness", newRoughness);
            lastRoughness = newRoughness;
        }
    }
}
