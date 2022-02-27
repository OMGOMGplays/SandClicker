using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public class OptionsMenu : Panel 
	{
		public OptionsMenu() 
		{
			StyleSheet.Load("/ui/main/options/OptionsMenu.scss");

			Add.Label("Options", "header");

			Add.Label("Test option", "button").AddEventListener("onclick", () => 
			{
				Log.Info("Test option button has been pressed!");
			});

			Add.Label("Return to game", "backbutton").AddEventListener("onclick", () => 
			{
				Log.Info("Should return!");
				Delete();
			});

			Add.Label("This is a description of the option", "desc");
		}
	}
}
