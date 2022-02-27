using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI
{
	public class UpgradeButton : Panel 
	{
		public UpgradeButton() 
		{
			StyleSheet.Load("/ui/upgrades/UpgradeButton.scss");

			Add.Label("", "button").AddEventListener("onclick", () => {
				Log.Info("Has Upgraded!");
			});
		}
	}
}
