using SkiaSharp;

namespace DiagramForge;
public sealed class Paragraph {
	public Fragment[] fragments;
	public float width;

	public Paragraph(Fragment[] fragments) {
		this.fragments = fragments;
	}

	public void Draw(int textSize, SKCanvas canvas, float y) {
		float x = 0;
		foreach (var fragment in fragments)
			fragment.Draw(textSize, canvas, ref x, y);
	}

	public void SetWidth(int textSize) {
		var paint = new SKPaint();
		paint.Typeface = SKTypeface.Default;
		paint.TextSize = textSize;

		float x = 0;
		foreach (var fragment in fragments)
			x += paint.MeasureText(fragment.text);
		width = x;
	}
}
