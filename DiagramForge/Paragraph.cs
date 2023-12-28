using SkiaSharp;

namespace DiagramForge;
public sealed class Paragraph {
	public List<Fragment> fragments = new();
	public float width;

	public void Draw(SKCanvas canvas, float y) {
		float x = 0;
		foreach (var fragment in fragments)
			fragment.Draw(canvas, ref x, y);
	}

	public void SetWidth(int textSize) {
		using var paint = new SKPaint();
		paint.Typeface = SKTypeface.Default;
		paint.TextSize = textSize;

		float x = 0;
		foreach (var fragment in fragments)
			x += paint.MeasureText(fragment.text);
		width = x;
	}
}
