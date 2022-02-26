using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace SC.UI 
{
	public partial class SandClickerUI : HudEntity<RootPanel>
	{
		public static SandClickerUI Instance {get; set;}

		public SandClickerUI() 
		{
			Instance = this;
		}

		public override void CreateRootPanel()
		{
			RootPanel?.Delete();

			base.CreateRootPanel();
			CreateUI();
		}

		public void CreateUI() 
		{
			RootPanel.AddChild<OptionsMenu>();
			RootPanel.AddChild<TestMenu>();
			RootPanel.AddChild<Sand>();
			RootPanel.AddChild<Buttons>();
		}

		[ClientCmd("sc_hud_reload")]
		public static void Command_ReloadHud() 
		{
			Host.AssertClient();
			Instance?.CreateRootPanel();
		}
	}
}
