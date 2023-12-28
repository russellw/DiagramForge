using SkiaSharp;

namespace DiagramForge;
public sealed class Fragment {
	public SKColor color;
	public string text;

	public Fragment(string text) {
		this.text = text;
	}

	public void Draw(int textSize, SKCanvas canvas, ref float x, float y) {
		var paint = new SKPaint();
		paint.Color = color;
		paint.TextSize = textSize;

		canvas.DrawText(text, x, y, paint);
		x += paint.MeasureText(text);
	}

	public override string ToString() {
		return text;
	}
}
