using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour {

	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	public int counter = 0;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{   
			counter++;
			if (counter==1 && this.name[0]=='L')
			{
				this.rb.velocity = new Vector2(0,-8);

			}
			if (counter==2 && this.name[0]=='T')
			{
				this.rb.velocity = new Vector2(0,-8);
			}
			if (counter==3 && this.name[0]=='C')
			{
				this.rb.velocity = new Vector2(0,-8);
			}
			if (counter==4 && this.name[0]=='B')
			{
				this.rb.velocity = new Vector2(0,-8);
			}
			if (counter==5 && this.name[0] == 'P')
			{
				this.rb.velocity = new Vector2(0,-8);
			}
			if (counter==6 && this.name[0]=='O')
			{
				this.rb.velocity = new Vector2(0,-8);
			}
			if (counter==7 && this.name[0]=='t')
			{
				this.rb.velocity = new Vector2(0,-8);
			}
		}
	}
}
