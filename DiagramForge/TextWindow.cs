namespace DiagramForge {
public sealed class TextWindow: Window {
	public TextLine[] Text;

	public TextWindow(TextLine[] text) {
		Text = text;
	}
}
}