using SkiaSharp;

namespace DiagramForge;
public abstract class MultiContainer: Window {
	public List<Window> contents = new();

	public override void Draw(SKCanvas canvas) {
		foreach (var window in contents)
			window.Draw(canvas);
	}
}
