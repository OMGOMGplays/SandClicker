using Sandbox;
using System;
using System.Linq;
using SC.UI;

namespace SC
{
	public partial class SCPlayer : Player
	{
		public override void Spawn()
		{
			base.Spawn();
		}

		public override void Respawn()
		{
			base.Respawn();
			
			SetModel("models/editor/playerstart.vmdl");
			EnableHideInFirstPerson = true;
		}

		public override void Simulate( Client cl )
		{
			base.Simulate( cl );
		}
	}
}
