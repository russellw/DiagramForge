namespace DiagramForge;
public sealed class Border: SingleContainer {
	public float radius = 2;

	public Border(Window content): base(content) {
	}

	public override void SetPosition(float x, float y) {
		base.SetPosition(x, y);
		content.SetPosition(x + radius, y + radius);
	}

	public override void SetSize() {
		content.SetSize();
		width = content.width + radius * 2;
		height = content.height + radius * 2;
	}
}
