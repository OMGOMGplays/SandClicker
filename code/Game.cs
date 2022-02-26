using Sandbox;
using SC.UI;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace SC
{
	/// <summary>
	/// The game
	/// </summary>
	public partial class SandClickerGame : Game
	{
		public static SandClickerGame Instance {get; private set;}

		public SandClickerGame()
		{
			Instance = this;

			PlaySound("music.placeholders");

			if (IsClient) 
			{
				_ = new SandClickerUI();
			}
		}

		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			// Create a pawn for this client to play with
			var player = new SCPlayer();
			client.Pawn = player;

			player.Spawn();
		}
	}

}
