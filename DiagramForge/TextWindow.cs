using SkiaSharp;

namespace DiagramForge {
public sealed class TextWindow: Window {
	public TextLine[] Text;
	public int TextSize = 12;

	public TextWindow(TextLine[] text) {
		Text = text;
	}
}
}