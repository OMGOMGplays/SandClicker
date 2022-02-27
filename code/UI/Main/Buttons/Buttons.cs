using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public class Buttons : Panel 
	{
		public Buttons() 
		{
			StyleSheet.Load("/ui/main/buttons/Buttons.scss");

			foreach (var prchbl in Purchasable.Names) 
			{
				var name = prchbl.Value;
				var val = prchbl.Key;

				Add.Label($"{name}", "button").AddEventListener("onclick", () => 
				{
					Log.Info("Purchased " + name + "!");

				});
			}

			Add.Label("Open options", "optionsbutton").AddEventListener("onclick", () => 
			{
				Log.Info("Should open options now!");
				AddChild<OptionsMenu>();
			});

			Add.Label("Open stats", "statsbutton").AddEventListener("onclick", () => 
			{
				Log.Info("Should open stats now!");
				AddChild<StatsMenu>();
			});
		}
	}
}
