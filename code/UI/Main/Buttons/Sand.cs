using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public class Sand : Panel 
	{
		public Sand() 
		{
			var player = Local.Pawn as SCPlayer;

			StyleSheet.Load("/ui/main/buttons/Sand.scss");

			Add.Label("", "button").AddEventListener("onclick", () => 
			{
				Log.Info("Added sand!");
				// player.TotalSand += 1;
			});
		}
	}
}
