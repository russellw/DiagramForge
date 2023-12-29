using SkiaSharp;

namespace DiagramForge;
public sealed class TextLine: Window {
	public List<Fragment> fragments = new();

	public void Draw(SKCanvas canvas, float y) {
		float x = 0;
		foreach (var fragment in fragments)
			fragment.Draw(canvas, ref x, y);
	}

	public void SetWidth() {
		using var paint = new SKPaint();
		paint.Typeface = SKTypeface.Default;

		float x = 0;
		foreach (var fragment in fragments)
			x += paint.MeasureText(fragment.text);
		size.Width = x;
	}
}
