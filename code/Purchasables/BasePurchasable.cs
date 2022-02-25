using Sandbox;

namespace SC 
{
	public abstract partial class BasePurchasable : AnimEntity 
	{
		[Net, Predicted]
		public Purchasable Data {get; set;}

		[Net] public bool IsBought {get; set;}

		public float Expense {get; set;}

		[Net] public int AmountOfPurchasable {get; set;}

		public bool IsInitialized => Data != null;

		public void Initialize(Purchasable data) 
		{
			if (IsInitialized) return;
			if (data == null) return;

			Data = data;
			OnInitialized();
		}

		public virtual void OnInitialized() 
		{
			Host.AssertServer();
		}

		public virtual void OnBought() 
		{
			var player = Local.Pawn as SCPlayer;
			player.TotalSand -= Expense;
		}
	}
}
