using SkiaSharp;

namespace DiagramForge;
public sealed class Rectangle: Window {
	public SKColor color = new(0xff, 0xff, 0xff);
	public Window content;

	public Rectangle(Window content) {
		this.content = content;
	}

	public override void Draw(SKCanvas canvas) {
		using var paint = new SKPaint();
		paint.Color = color;
		canvas.DrawRect(x, y, width, height, paint);
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
}
