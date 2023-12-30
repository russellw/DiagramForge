using SkiaSharp;

namespace DiagramForge;
public sealed class Column: Window {
	public List<Window> contents = new();

	public override void Draw(SKCanvas canvas) {
		foreach (var window in contents)
			window.Draw(canvas);
	}

	public override void SetPosition(float x, float y) {
		base.SetPosition(x, y);
		foreach (var window in contents) {
			window.SetPosition(x, y);
			y += window.height;
		}
	}

	public override void SetSize() {
		width = 0;
		height = 0;
		foreach (var window in contents) {
			window.SetSize();
			width = Math.Max(width, window.width);
			height += window.height;
		}
	}
}
