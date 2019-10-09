using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	private float rotationX = 0f;
	private float rotationY = 0f;

    private Vector3 previousPosition;
    private Vector3 originalPosition;

    private Vector3 previousRotation;

    private Transform chalkRef;

    private void Start()
    {
        chalkRef = GameObject.Find("Chalk Ref").transform;
        chalkRef.parent = this.transform;
        previousPosition = chalkRef.position;
        originalPosition = chalkRef.position;
        chalkRef.localPosition = new Vector3(0f, 0f, 1f);
        UpdateHapticPosition();
    }

	// Update is called once per frame
	void Update () {

		float scroll = Input.GetAxis("Mouse ScrollWheel");
		transform.Translate(0, 0f, scroll * 0.1f, Space.Self);

		if (Input.GetMouseButton (1)) {
			rotationX += Input.GetAxis ("Mouse X") * 50f * Time.deltaTime;
			rotationY += Input.GetAxis ("Mouse Y") * 50f * Time.deltaTime;
			transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
		}
		else if (Input.GetMouseButton (2)) {
			var xMove = Input.GetAxis ("Mouse X") * -1f * Time.deltaTime;
			var yMove = Input.GetAxis ("Mouse Y") * -1f * Time.deltaTime;
			transform.Translate(xMove, yMove, 0f, Space.Self);
		}
        Debug.Log(transform.position);

        if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(0f, 0f, 0.5f * Time.deltaTime, Space.World);
		else if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(0f, 0f, -0.5f * Time.deltaTime, Space.World);
		else if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(-0.5f * Time.deltaTime, 0f, 0f, Space.World);
		else if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate(0.5f * Time.deltaTime, 0f, 0f, Space.World);
        else if (Input.GetKey(KeyCode.Keypad1))
            transform.position = new Vector3(2.04f, 0f, 0f);
        else if (Input.GetKey(KeyCode.Keypad2))
            transform.position = new Vector3(4.07f, 0f, 0f);
        else if (Input.GetKey(KeyCode.Keypad3))
            transform.position = new Vector3(0f, -1.04f, 0f);
        else if (Input.GetKey(KeyCode.Keypad4))
            transform.position = new Vector3(2.04f, -1.04f, 0f);
        else if (Input.GetKey(KeyCode.Keypad5))
            transform.position = new Vector3(4.07f, -1.04f, 0f);
        else if (Input.GetKey(KeyCode.Keypad6))
            transform.position = new Vector3(0f, -2.4f, 0f);
        else if (Input.GetKey(KeyCode.Keypad7))
            transform.position = new Vector3(2.04f, -2.4f, 0f);
        else if (Input.GetKey(KeyCode.Keypad8))
            transform.position = new Vector3(4.07f, -2.4f, 0f);
        else if (Input.GetKey(KeyCode.Keypad0))
            transform.position = new Vector3(0f, 0f, 0f);
        UpdateHapticPosition();
        UpdateHapticRotation();
	}

    private void UpdateHapticPosition()
    {
        if (chalkRef == null)
            return;
        if (previousPosition != chalkRef.position)
        {
            HapticNativePlugin.SetHapticPosition((chalkRef.position - originalPosition) / 0.1f);
        }
        previousPosition = chalkRef.position;
    }

    private void UpdateHapticRotation()
    {
        if (previousRotation != this.transform.rotation.eulerAngles)
        {
            HapticNativePlugin.SetHapticRotation(this.transform.rotation.eulerAngles);
        }
        previousPosition = this.transform.rotation.eulerAngles;
    }

}
