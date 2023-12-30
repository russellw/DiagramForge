using DiagramForge;

namespace TestProject1;
public class UnitTest1 {
	[Fact]
	public void Test1() {
		var text = new Text("foo");
		Assert.Equal("foo", text.ToString());
	}
}
