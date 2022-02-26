using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public class OptionsMenu : Panel 
	{
		public OptionsMenu() 
		{
			StyleSheet.Load("/ui/OptionsMenu.scss");

			Add.Label("Options", "header");

			Add.Label("Test option", "button").AddEventListener("onclick", () => 
			{
				Log.Info("Test option button has been pressed!");
			});

			Add.Label("Return to game", "backbutton").AddEventListener("onclick", () => 
			{
				Log.Info("Should return!");
				SetClass("hidden", true);
			});

			Add.Label("This is a description of the option", "desc");
		}
	}

	// public class OptionsMenuEntranceButton : Panel 
	// {
	// 	public OptionsMenuEntranceButton() 
	// 	{
	// 		Add.Label("Open options", "button").AddEventListener("onclick", () => 
	// 		{
	// 			Log.Info("Should open options now!");
	// 			AddChild<OptionsMenu>();
	// 		});
	// 	}
	// }

	public class OptionsMenuSelections : Panel 
	{
		public OptionsMenuSelections() 
		{
			// Add.Label("Options", "header");

			// Add.Label("Test option", "button").AddEventListener("onclick", () => 
			// {
			// 	Log.Info("Test option button has been pressed!");
			// });

			// Add.Label("Return to game", "backbutton").AddEventListener("onclick", () => 
			// {
			// 	Log.Info("Should return!");
			// 	SetClass("hidden", true);
			// });

			// Add.Label("This is a description of the option", "desc");
		}
	}
}
