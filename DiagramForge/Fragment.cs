using SkiaSharp;

namespace DiagramForge {
public sealed class Fragment {
	public SKColor color;
	public string text;

	public Fragment(string text, SKColor color) {
		this.text = text;
		this.color = color;
	}

	public void Draw(int textSize, SKCanvas canvas, ref float x, float y) {
		var paint = new SKPaint();
		paint.Color = color;
		paint.TextSize = textSize;

		canvas.DrawText(text, x, y, paint);
		x += paint.MeasureText(text);
	}
}
}
