using SkiaSharp;

namespace DiagramForge {
public sealed class TextFragment {
	public SKColor Color;
	public string Text;

	public TextFragment(string text, SKColor color) {
		Text = text;
		Color = color;
	}
}
}
