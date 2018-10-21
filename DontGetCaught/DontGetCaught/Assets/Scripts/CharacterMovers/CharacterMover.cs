
using UnityEngine;

public class CharacterMover<Float> : MonoBehaviour 
{

    public CharacterController Controller;
    private Vector3 position;
	public Float Speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        position.x = Speed * Input.GetAxis("horizontal");
		Controller.Move(position * Time.deltaTime);

	}
}
