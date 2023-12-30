using SkiaSharp;

namespace DiagramForge;
public abstract class Window {
	public SKPoint position;
	public SKSize size;

	public abstract void Draw(SKCanvas canvas);
	public abstract void SetSize();
}
