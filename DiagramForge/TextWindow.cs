using SkiaSharp;

namespace DiagramForge {
public sealed class TextWindow: Window {
	public Paragraph[] paragraphs;
	public int textSize = 12;

	public TextWindow(Paragraph[] paragraphs) {
		this.paragraphs = paragraphs;
	}
}
}
