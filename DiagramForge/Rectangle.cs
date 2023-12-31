using SkiaSharp;

namespace DiagramForge;
public sealed class Rectangle: SingleContainer {
	public SKColor color = new(0xff, 0xff, 0xff);

	public Rectangle(Window content): base(content) {
	}

	public override void Draw(SKCanvas canvas) {
		using var paint = new SKPaint();
		paint.Color = color;
		canvas.DrawRect(x, y, width, height, paint);
		content.Draw(canvas);
	}
}
