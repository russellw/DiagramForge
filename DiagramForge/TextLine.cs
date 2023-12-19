using SkiaSharp;

namespace DiagramForge {
public sealed class TextLine {
	public TextFragment[] Text;
	public float Width;

	public TextLine(TextFragment[] text) {
		Text = text;
	}

	public void SetWidth(int textSize) {
		var paint = new SKPaint();
		paint.TextSize = textSize;
		float x = 0;
		foreach (var fragment in Text)
			x += paint.MeasureText(fragment.Text);
		Width = x;
	}
}
}
