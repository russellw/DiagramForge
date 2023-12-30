using DiagramForge;

namespace TestProject1;
public class UnitTest1 {
	[Fact]
	public void Test1() {
		var text = new Text("foo");
		Assert.Equal("foo", text.ToString());
		text.SetSize();
		Assert.True(1 < text.size.Width);
		Assert.True(1 < text.size.Height);

		var row = new Row();
		row.contents.Add(new Text("foo"));
		row.contents.Add(new Text("bar"));
		row.SetSize();
		Assert.True(1 < row.size.Width);
		Assert.True(1 < row.size.Height);
		Assert.Equal(row.size.Width, row.contents[0].size.Width + row.contents[1].size.Width);
		Assert.Equal(row.size.Height, Math.Max(row.contents[0].size.Height, row.contents[1].size.Height));
	}
}
