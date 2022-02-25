using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI
{
	public class TestMenu : Panel 
	{
		public TestMenu() 
		{
			var player = Local.Pawn as SCPlayer;
			// var currSand = player.TotalSand;

			// Log.Info("Player is: " + player);

			StyleSheet.Load("/ui/TestMenu.scss");

			Add.Label("Sand Count: ", "header");

			AddChild<TestMenuButtons>();
			AddChild<TestMenuSand>();
			AddChild<TestMenuPurchasables>();
		}

		public override void Tick()
		{
			base.Tick();

			var player = Local.Pawn as SCPlayer;
			// var currSand = player.TotalSand;

			// if (player.IsValid()) 
			// {
			// 	Log.Info("Player is: " + player);
			// }
			// else 
			// {
			// 	return;
			// }
		}
	}

	public class TestMenuButtons : Panel 
	{
		public TestMenuButtons() 
		{
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
		}
	}

	public class TestMenuSand : Panel 
	{
		public TestMenuSand() 
		{
			var player = Local.Pawn as SCPlayer;

			Add.Label("", "button").AddEventListener("onclick", () => 
			{
				Log.Info("Added sand!");
				// player.TotalSand += 1;
			});
		}
	}

	public class TestMenuPurchasables : Panel 
	{
		public TestMenuPurchasables() 
		{
			var player = Local.Pawn as SCPlayer;

			Add.Label("Total Purchasables: ", "section");
		}
	}
}
