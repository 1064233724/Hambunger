using UnityEngine;
using System.Collections;

public class playButton : MonoBehaviour {

	private Sprite touched;
	private Sprite def;
	private AudioClip clicked;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		touched = Resources.Load<Sprite>("playbutton");
		def = Resources.Load<Sprite>("playbutton1");
		clicked = Resources.Load<AudioClip>("Start");
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.touchCount > 0) {
				checkTouch(Input.GetTouch(0));
		}
	}

	void checkTouch(Touch touch){
		Ray ray = Camera.main.ScreenPointToRay(touch.position);
		RaycastHit hitinfo;
		bool hit = GetComponent<Collider> ().Raycast (ray, out hitinfo, 100);

		if(hit) {
			if(touch.phase == TouchPhase.Began)
				spriteRenderer.sprite = touched;
			if(touch.phase == TouchPhase.Ended)
			{
				spriteRenderer.sprite = def;
				AudioSource source = GetComponent<AudioSource>();
				source.PlayOneShot(clicked);
				AutoFade.LoadLevel(1, 0.5f, 0.5f, Color.black);
			}
		}
		if (touch.phase == TouchPhase.Ended)
			if (spriteRenderer.sprite != def)
				spriteRenderer.sprite = def;
	}
}
