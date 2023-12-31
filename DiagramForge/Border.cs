using SkiaSharp;

namespace DiagramForge;
public sealed class Border: Window {
	public Window content;
	public float radius = 2;

	public Border(Window content) {
		this.content = content;
	}

	public override void Draw(SKCanvas canvas) {
		content.Draw(canvas);
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
