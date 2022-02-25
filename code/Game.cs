using Sandbox;
using SC.UI;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace SC
{
	/// <summary>
	/// This is your game class. This is an entity that is created serverside when
	/// the game starts, and is replicated to the client. 
	/// 
	/// You can use this to create things like HUDs and declare which player class
	/// to use for spawned players.
	/// </summary>
	public partial class SandClickerGame : Game
	{
		public static SandClickerGame Instance {get; private set;}

		public SandClickerGame()
		{
			Instance = this;

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
			// var pawn = new SCPlayer();
			// client.Pawn = pawn;

			// player.Spawn();
		}
	}

}
