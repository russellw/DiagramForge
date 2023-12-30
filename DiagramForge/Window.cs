using SkiaSharp;

namespace DiagramForge;
public abstract class Window {
	public float width, height;
	public float x, y;

	public abstract void Draw(SKCanvas canvas);

	public virtual void SetPosition(float x, float y) {
		this.x = x;
		this.y = y;
	}

	public abstract void SetSize();
}
