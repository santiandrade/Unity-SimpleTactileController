using UnityEngine;

public class CubeController : MonoBehaviour
{
	public float Speed = 5.0F;

	private bool right = false;
	private bool left = false;
	private bool up = false;
	private bool down = false;
	private bool increase = false;
	private bool decrease = false;

	void Update()
	{
		if (right)
		{
			this.transform.Translate(Vector3.right * Time.deltaTime * Speed);
		}

		if (left)
		{
			this.transform.Translate(Vector3.left * Time.deltaTime * Speed);
		}

		if (up)
		{
			this.transform.Translate(Vector3.up * Time.deltaTime * Speed);
		}

		if (down)
		{
			this.transform.Translate(Vector3.down * Time.deltaTime * Speed);
		}

		if (increase)
		{
			this.transform.localScale = new Vector3(
				this.transform.localScale.x + 0.05F,
				this.transform.localScale.y + 0.05F,
				this.transform.localScale.z + 0.05F);
		}

		if (decrease)
		{
			this.transform.localScale = new Vector3(
				this.transform.localScale.x - 0.05F,
				this.transform.localScale.y - 0.05F,
				this.transform.localScale.z - 0.05F);
		}
	}

	public void MoveRight()
	{
		right = true;
	}

	public void MoveLeft()
	{
		left = true;
	}

	public void MoveUp()
	{
		up = true;
	}

	public void MoveDown()
	{
		down = true;
	}

	public void StopMovement()
	{
		right = false;
		left = false;
		up = false;
		down = false;
	}

	public void IncreaseScale()
	{
		increase = true;
	}

	public void DecreaseScale()
	{
		decrease = true;
	}

	public void StopScaling()
	{
		increase = false;
		decrease = false;
	}
}
