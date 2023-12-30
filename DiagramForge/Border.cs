using SkiaSharp;

namespace DiagramForge;
public sealed class Border: Window {
	public SKColor background = new(0xff, 0xff, 0xff);
	public SKColor color = new(0, 0, 0);
	public Window content;
	public float thickness = 2;

	public Border(Window content) {
		this.content = content;
	}

	public override void Draw(SKCanvas canvas) {
		using var paint = new SKPaint();
		paint.Color = color;
		canvas.DrawRect(position.X, position.Y, size.Width, size.Height, paint);
		paint.Color = background;
		canvas.DrawRect(content.position.X, content.position.Y, content.size.Width, content.size.Height, paint);
	}

	public override void SetSize() {
		content.SetSize();
		size.Width = content.size.Width + thickness * 2;
		size.Height = content.size.Height + thickness * 2;
	}
}
