using UnityEngine;
using UnityEngine.UI;

public class USlider : MonoBehaviour {

	// Unity UI References
	public Slider slider;
	public Text displayText;

	// Create a property to handle the slider's value
	public float currentValue = 0f;
	public float CurrentValue {
		get {
			return currentValue;
		}
		set {
			currentValue = value;
			slider.value = currentValue;
			displayText.text = (slider.value * 100).ToString("0.00") + "%";
		}
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.currentValue = Mathf.Max (Mathf.Min(0, Mathf.Abs (1 - SampleApp.res), 1));
	}
}