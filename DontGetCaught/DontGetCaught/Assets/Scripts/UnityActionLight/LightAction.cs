
using UnityEngine;
using UnityEngine.Events

                 ;public class LightAction : MonoBehaviour
{

    public UnityAction LightSwitch;



    void Start()
    {

        LightSwitch = LightOn;

    }

    private void OnMouseDown()
    {
        LightSwitch();
    }

    private void LightOn()
    {
        Debug.Log("on");
        LightSwitch = LightOff;
    }

    private void LightOff()
    {
        Debug.Log("off");
        LightSwitch = LightOn;
    }
}