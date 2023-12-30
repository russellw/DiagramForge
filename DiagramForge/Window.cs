using SkiaSharp;

namespace DiagramForge;
public abstract class Window {
	public float width, height;
	public float x, y;

	public abstract void Draw(SKCanvas canvas);

	public abstract void SetSize();
}
