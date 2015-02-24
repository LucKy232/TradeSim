using UnityEngine;
using System.Collections;

public class TradeResource
{
	string name;
	int amount;				//in tonnes (metric ton)
	float sellCost;
	float buyCost;

	// Use this for initialization
	public TradeResource () 
	{
		name = null;
		amount = 0;
		sellCost = 0.00f;
		buyCost = 0.00f;
	}

	public TradeResource (string resName, int available, float buy, float sell) 
	{
		name = resName;
		amount = available;
		buyCost = buy;
		sellCost = sell;
	}

	public void SetSellCost(float x)
	{
		sellCost = x;
	}

	public void ChangeSellCost(float x)
	{
		sellCost += x;
	}

	public void SetBuyCost(float x)
	{
		buyCost = x;
	}
	
	public void ChangeBuyCost(float x)
	{
		buyCost += x;
	}

	//a ship buys from the station
	public float Buy(int x)		//input: amount; output: money
	{
		float money;

		if (x < amount) {
			amount -= x;
			money = buyCost * x;
		} else {
			amount = 0;
			money = buyCost * amount;
		}

		return money;
	}

	//a ship sells to the station
	public void Sell(int x)
	{
		if(x > 0)
			amount += x;
	}

	public string GetName()
	{
		return name;
	}
}
