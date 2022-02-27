using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public class StatsMenu : Panel 
	{
		public StatsMenu() 
		{
			StyleSheet.Load("/ui/main/StatsMenu.scss");

			Add.Label("Stats Menu", "header");

			Add.Label("Test statistic", "stat");
			Add.Label("Test description for the statistic", "desc");

			Add.Label("Return to game", "backbutton").AddEventListener("onclick", () => 
			{
				Log.Info("Should return now!");
				Delete();
			});
		}
	}
}
