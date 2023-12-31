using SkiaSharp;

namespace DiagramForge;
public abstract class SingleContainer: Window {
	public Window content;

	public override void Draw(SKCanvas canvas) {
		content.Draw(canvas);
	}

	public override void SetPosition(float x, float y) {
		base.SetPosition(x, y);
		content.SetPosition(x, y);
	}

	public override void SetSize() {
		content.SetSize();
		width = content.width;
		height = content.height;
	}

	protected SingleContainer(Window content) {
		this.content = content;
	}
}
