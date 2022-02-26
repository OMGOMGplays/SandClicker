using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public class UpgradeBox : Panel 
	{
		public UpgradeBox() 
		{
			StyleSheet.Load("/ui/upgrades/UpgradeBox.scss");

			Add.Panel("upgradebox");
		}
	}
}
