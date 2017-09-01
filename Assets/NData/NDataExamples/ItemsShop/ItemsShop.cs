using UnityEngine;
using System.Collections.Generic;
using ItemsShopContexts;

namespace ItemsShopContexts
{
	public class Item : EZData.Context
	{
		#region Property Name
		private readonly EZData.Property<string> _privateNameProperty = new EZData.Property<string>();
		public EZData.Property<string> NameProperty { get { return _privateNameProperty; } }
		public string Name
		{
		get    { return NameProperty.GetValue();    }
		set    { NameProperty.SetValue(value); }
		}
		#endregion
		
		#region Property Icon
		private readonly EZData.Property<string> _privateIconProperty = new EZData.Property<string>();
		public EZData.Property<string> IconProperty { get { return _privateIconProperty; } }
		public string Icon
		{
		get    { return IconProperty.GetValue();    }
		set    { IconProperty.SetValue(value); }
		}
		#endregion
		
		#region Property SellPrice
		private readonly EZData.Property<int> _privateSellPriceProperty = new EZData.Property<int>();
		public EZData.Property<int> SellPriceProperty { get { return _privateSellPriceProperty; } }
		public int SellPrice
		{
		get    { return SellPriceProperty.GetValue();    }
		set    { SellPriceProperty.SetValue(value); }
		}
		#endregion
		
		#region Property BuyPrice
		private readonly EZData.Property<int> _privateBuyPriceProperty = new EZData.Property<int>();
		public EZData.Property<int> BuyPriceProperty { get { return _privateBuyPriceProperty; } }
		public int BuyPrice
		{
		get    { return BuyPriceProperty.GetValue();    }
		set    { BuyPriceProperty.SetValue(value); }
		}
		#endregion
	}
	
	public class Character : EZData.Context
	{
		#region Collection Backpack
		private readonly EZData.Collection<Item> _privateBackpack =
			new EZData.Collection<Item>(true);
		public EZData.Collection<Item> Backpack { get { return _privateBackpack; } }
		#endregion
		
		#region Property Gold
		private readonly EZData.Property<int> _privateGoldProperty = new EZData.Property<int>();
		public EZData.Property<int> GoldProperty { get { return _privateGoldProperty; } }
		public int Gold
		{
		get    { return GoldProperty.GetValue();    }
		set    { GoldProperty.SetValue(value); }
		}
		#endregion
	}
}

public class ItemsShop : EZData.MonoBehaviourContext
{
	public Character Hero { get; private set; }
	public Character Merchant { get; private set; }
	
	public ItemsShop()
	{
		Hero = new Character { Gold = 100 };
		Hero.Backpack.Add(new Item { Name = "Boots of Haste", Icon = "YellowButton", BuyPrice = 15, SellPrice = 12 });
		Hero.Backpack.Add(new Item { Name = "Bracers of Strength", Icon = "RedButton", BuyPrice = 8, SellPrice = 7 });
		Hero.Backpack.Add(new Item { Name = "Bracers of Agility", Icon = "GreenButton", BuyPrice = 13, SellPrice = 11 });
		Hero.Backpack.Add(new Item { Name = "Shoulders of Spell Power", Icon = "BlueButton", BuyPrice = 25, SellPrice = 20 });
		
		Merchant = new Character { Gold = 200 };
	}
	
	public NguiRootContext View;
	void Awake()
	{
		View.SetContext(this);
	}
}
