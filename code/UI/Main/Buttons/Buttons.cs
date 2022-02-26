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

			var player = Local.Pawn as SCPlayer;

			foreach (var prchbl in Purchasable.Names) 
			{
				var name = prchbl.Value;
				var val = prchbl.Key;

				Add.Label($"{name}", "button").AddEventListener("onclick", () => 
				{
					Log.Info("Purchased " + name + "!");
					// player.TotalPurchasables++;
				});
			}

			Add.Label("Open options", "optionsbutton").AddEventListener("onclick", () => 
			{
				Log.Info("Should open options now!");
				AddChild<OptionsMenu>();
			});
		}
	}
}
