using Sandbox;
using System.Collections.Generic;
using System.Linq;

namespace SC 
{
	public enum Purchasables 
	{
		Hand = 0,
		Grannie,
		Mine
	}

	[Library("scpurch"), AutoGenerate]
	public class Purchasable : Asset 
	{
		public static Dictionary<string, Purchasable> All {get; set;} = new();

		public static Dictionary<Purchasables, string> Names {get; set;} = new() 
		{
			{Purchasables.Hand, "hand"},
			{Purchasables.Grannie, "grandma"},
			{Purchasables.Mine, "mine"}
		};

		public static Dictionary<string, Purchasables> Entries {get; set;} = Names.ToDictionary(x => x.Value, x => x.Key);

		/// <summary>
		/// The title of this purchasable
		/// </summary>
		public string Title {get; set;}

		/// <summary>
		/// How much this purchasable should cost
		/// </summary>
		public float Expense {get; set;}

		/// <summary>
		/// The amount of Clicks Per Second this purchasable has
		/// </summary>
		public float CPS {get; set;}
		
		/// <summary>
		/// Can this purchasable be upgraded?
		/// </summary>
		public bool CanBeUpgraded {get; set;}

		protected override void PostLoad()
		{
			base.PostLoad();

			string prchsblname = Name.ToLower();

			All[prchsblname] = this;
		}

		protected override void PostReload()
		{
			base.PostReload();
		}

		// public static Purchasable GetExpense(float xpns) 
		// {
			
		// }
	}
}
