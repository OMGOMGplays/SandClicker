using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI
{
	public class SanderyName : Panel 
	{
		public SanderyName() 
		{
			StyleSheet.Load("/ui/main/SanderyName.scss");
			
			{
				var name = AddText("", "");
				name.Placeholder = "";
				name.Suffix = "'s Sandery";
				name.MaxLength = 25;
			}
		}

		private TextEntry AddText(string style, string text) 
		{
			var p = Add.TextEntry("");
			p.Placeholder = text;
			p.Style.Set(style);
			
			return p;
		}
	}
}
